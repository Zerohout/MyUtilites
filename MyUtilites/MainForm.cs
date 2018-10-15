using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtilites
{
    public partial class MainForm : Form
    {

        List<string> itemList = new List<string>();
        int count = 0;
        int balance;
        int cheat;
        Random rnd;
        char[] specChars = new char[] { '%', '*', ')', '?', '#', '$', '^', '&', '~' };
        Dictionary<string, double> metrica;
        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
            metrica = new Dictionary<string, double>();
            metrica.Add("mm", 1);
            metrica.Add("cm", 10);
            metrica.Add("dm", 100);
            metrica.Add("m", 1000);
            metrica.Add("km", 1000000);
            metrica.Add("mile", 1609344);
        }

        private void MainForm_Load(object sender, EventArgs e) //Загрузка Основной формы
        {
            if (tbAddToList.Text.Length == 0)
            {
                btnAddToList.Enabled = false;
            }
            if (lbCountList.SelectedItems != null)
            {
                btnAddCountToList.Enabled = false;
            }
            nudCheatNum.Minimum = nudMin.Value;
            nudCheatNum.Maximum = nudMax.Value;
            #region Генерация
            if (!cbAutoGen.Checked)
            {
                lblNumGen.Enabled = false;
                nudNumGen.Enabled = false;
                cbAutoCopy.Enabled = false;
                cbAutoClear.Enabled = false;
            }
            if (!cbCheatMode.Checked)
            {
                nudCheatNum.Enabled = false;
                nudCheatLvl.Enabled = false;
                lblCheatLvl.Enabled = false;
                lblCheatNum.Enabled = false;
            }
            #endregion
            LoadNotepad();
            clbPass.SetItemChecked(rnd.Next(clbPass.Items.Count), true);
        }

        #region Счетчик

        private void btnPlus_Click(object sender, EventArgs e) //Кнопка +
        {
            count++;
            lblCount.Text = count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e) //Кнопка -
        {
            count--;
            lblCount.Text = count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e) //Кнопка сброса
        {
            count = 0;
            lblCount.Text = Convert.ToString(count);
            lblRandom.Text = count.ToString();
        }

        private void tbAddToList_TextChanged(object sender, EventArgs e)
        {
            if (tbAddToList.Text.Length > 0)
            {
                btnAddToList.Enabled = true;
            }
            else
            {
                btnAddToList.Enabled = false;
            }
            if (lbCountList.Items.Contains(tbAddToList.Text + "\t" + lblCount.Text))
            {
                btnAddToList.Enabled = false;
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            itemList.Add(tbAddToList.Text);
            lbCountList.Items.Add(tbAddToList.Text + "\t" + lblCount.Text);
            tbAddToList.Clear();
            count = 0;
            lblCount.Text = "0";
        }

        private void lbCountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddCountToList.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbCountList.SelectedItems != null)
            {
                int i = lbCountList.SelectedIndex;

                string item = itemList[i] + "\t" + lblCount.Text;
                lbCountList.Items.Remove(lbCountList.SelectedItem);
                lbCountList.Items.Add(item);
            }
            lblCount.Text = "0";
            count = 0;
        }

        #endregion

        #region Генератор чисел 
        //Прикрутить генерацию чисел с установленной вероятностью в процентах.

        #region Кнопка Начать (генерация рандомного числа)
        private void btnRandom_Click(object sender, EventArgs e) //Кнопка Начать (Генерация рандомного числа)
        {
            int n;
            int i = 0;
            int iMin = 0;
            int iMax = Convert.ToInt32(nudNumGen.Value);

            if (cbAutoClear.Checked)
            {
                tbRandom.Clear();
            }

            #region Режим Без повторов
            if (cbNonRepiteMode.Checked) //Режим Без повторов Активен
            {
                if (cbAutoGen.Checked) //Автомат Активен
                {
                    while (iMin != iMax)
                    {
                        n = randomNum();
                        while (!tbRandom.Text.Contains(n.ToString()) && i < 1000)
                        {
                            tbRandom.AppendText(n + "\n");
                            i++;
                        }
                        iMin++;
                    }
                }
                else if (!cbAutoGen.Checked) //Автомат Не активен
                {
                    n = randomNum();
                    while (!tbRandom.Text.Contains(n.ToString()) && i < 1000)
                    {
                        tbRandom.AppendText(n + "\n");
                        lblRandom.Text = n.ToString();
                        i++;
                    }
                }

            }
            #endregion
            #region Режим баланса
            else if (cbBalanceMode.Checked)
            {
                if (cbAutoGen.Checked) //Автомат Активен
                {
                    while (iMin != iMax)
                    {
                        n = randomNum();
                        while (balance == n)
                        {
                            n = randomNum();
                        }
                        iMin++;
                        tbRandom.AppendText(n + "\n");
                        balance = n;
                    }
                }
                else //Автомат Не активен
                {
                    n = randomNum();
                    while (balance == n)
                    {
                        n = randomNum();
                    }
                    iMin++;
                    tbRandom.AppendText(n + "\n");
                    balance = n;
                }

            }
            #endregion
            #region Режим Жулика
            else if (cbCheatMode.Checked) //Режим Жулика активен
            {
                if (cbAutoGen.Checked) //Автомат Активен
                {
                    while (iMin != iMax)
                    {
                        n = randomNum();

                        while (cheat != nudCheatLvl.Value)
                        {
                            if (n == nudCheatNum.Value)
                            {
                                break;
                            }
                            n = randomNum();
                            cheat++;
                        }
                        iMin++;
                        tbRandom.AppendText(n + "\n");
                        cheat = 0;
                    }
                }
                else if (!cbAutoGen.Checked) //Автомат Не активен
                {
                    n = randomNum();
                    while (cheat != nudCheatLvl.Value)
                    {
                        if (n == nudCheatNum.Value)
                        {
                            break;
                        }
                        n = randomNum();
                        cheat++;
                    }
                    tbRandom.AppendText(n + "\n");
                    cheat = 0;
                }
                nudCheatLvl.Enabled = false;
                nudCheatNum.Enabled = false;
                lblCheatLvl.Enabled = false;
                lblCheatNum.Enabled = false;

            }
            #endregion
            #region Без режимов
            else
            {
                if (cbAutoGen.Checked) //Автомат Активен
                {
                    while (iMin != iMax)
                    {
                        n = randomNum();
                        tbRandom.AppendText(n + "\n");
                        iMin++;
                    }
                }
                else //Автомат Не активен
                {
                    n = randomNum();
                    tbRandom.AppendText(n + "\n");
                    lblRandom.Text = n.ToString();
                }
            }
            cbAutoGen.Enabled = false;
            cbNonRepiteMode.Enabled = false;
            cbBalanceMode.Enabled = false;
            cbCheatMode.Enabled = false;
            if (cbAutoCopy.Checked)
            {
                Clipboard.SetText(tbRandom.Text);

            }
        }
        #endregion
        #endregion

        private Int32 randomNum() //Возврат рандомного числа
        {
            int num = rnd.Next(Convert.ToInt32(nudMin.Value), Convert.ToInt32(nudMax.Value) + 1);
            return num;
        }

        private void btnAboutModes_Click(object sender, EventArgs e) //Кнопка О режимах
        {
            MessageBox.Show("Во избежании ошибок в программе, после начала генерации чисел все режимы блокируются (выбранные режимы остаются действующими). Чтобы разблокировать их - нажмите \"Сброс\".\n" +
                "---Автоочистка - автоматическая очистка сгенерированных чисел после повторной генерации\n" +
                "---Автокопирование - автоматически копирует сгенерированные числа в буфер обмена\n" +
                "\t\t\t***Режимы***\n" +
                "---Режим автогенерации - число генераций, которое пройдет в автоматическом режиме (избавит вас от многократного нажатия на кнопку \"Начать\".\n" +
                "---Режим пропуск повторов - не добавляет в список те числа, которые в нём уже присутствуют.\n" +
                "---Режим равновесия - дает гарантию того, что следующее число не будет равно предыдущему.\n" +
                "---Режим жулика - даёт повышенный шанс получить указанное число.\n" +
                "--Нужное число - число, которое вы хотите получить с повышенным шансом в режиме жулика\n" +
                "--Степень жульничества - степень того, насколько бОльший шанс выпадения имеет нужное число", "Справка");
        }

        private void cbNonRepite_CheckedChanged(object sender, EventArgs e) //Режим Без повторов
        {
            if (cbNonRepiteMode.Checked)
            {
                cbBalanceMode.Enabled = false;
                cbCheatMode.Enabled = false;
            }
            else
            {
                cbBalanceMode.Enabled = true;
                cbCheatMode.Enabled = true;
            }
        }

        private void cbBalanceMode_CheckedChanged(object sender, EventArgs e) //Режим Баланса
        {
            if (cbBalanceMode.Checked)
            {
                cbCheatMode.Enabled = false;
                cbNonRepiteMode.Enabled = false;
            }
            else
            {
                cbCheatMode.Enabled = true;
                cbNonRepiteMode.Enabled = true;
            }
        }

        private void cbCheatMode_CheckedChanged(object sender, EventArgs e) //Режим Жулика
        {
            if (cbCheatMode.Checked)
            {
                cbBalanceMode.Enabled = false;
                cbNonRepiteMode.Enabled = false;
                nudCheatNum.Enabled = true;
                nudCheatLvl.Enabled = true;
                lblCheatNum.Enabled = true;
                lblCheatLvl.Enabled = true;
            }
            else
            {
                cbBalanceMode.Enabled = true;
                cbNonRepiteMode.Enabled = true;
                nudCheatNum.Enabled = false;
                nudCheatLvl.Enabled = false;
                lblCheatNum.Enabled = false;
                lblCheatLvl.Enabled = false;
            }
        }

        private void nudMin_ValueChanged(object sender, EventArgs e) //Изменение минимального значения Генерации
        {
            nudCheatNum.Minimum = nudMin.Value;
        }

        private void nudMax_ValueChanged(object sender, EventArgs e) //Изменение максимального значения Генерации
        {
            nudCheatNum.Maximum = nudMax.Value;
        }

        private void tbRanClear_Click(object sender, EventArgs e) //Кнопка очистки сгенерированных чисел
        {
            tbRandom.Clear();
            lblRandom.Text = "0";
            balance = 0;
            cheat = 0;
            if (cbNonRepiteMode.Checked)
            {
                cbNonRepiteMode.Enabled = true;
                cbAutoGen.Enabled = true;
            }
            else if (cbBalanceMode.Checked)
            {
                cbBalanceMode.Enabled = true;
                cbAutoGen.Enabled = true;
            }
            else if (cbCheatMode.Checked)
            {
                cbCheatMode.Enabled = true;
                cbAutoGen.Enabled = true;
                nudCheatLvl.Enabled = true;
                nudCheatNum.Enabled = true;
                lblCheatLvl.Enabled = true;
                lblCheatNum.Enabled = true;
            }
            else
            {
                cbAutoGen.Enabled = true;
                cbNonRepiteMode.Enabled = true;
                cbBalanceMode.Enabled = true;
                cbCheatMode.Enabled = true;
                nudCheatLvl.Enabled = true;
                nudCheatNum.Enabled = true;
            }
        }

        private void btRanCopy_Click(object sender, EventArgs e) //Кнопка копирования сгенерированных чисел
        {
            Clipboard.SetText(tbRandom.Text);
        }

        private void cbNumGen_CheckedChanged(object sender, EventArgs e) //Автоматическая генерация Чисел
        {
            if (cbAutoGen.Checked)
            {
                lblNumGen.Enabled = true;
                nudNumGen.Enabled = true;
                lblRandom.Enabled = false;
                cbAutoCopy.Enabled = true;
                cbAutoClear.Enabled = true;
            }
            else
            {
                lblNumGen.Enabled = false;
                nudNumGen.Enabled = false;
                lblRandom.Enabled = true;
                cbAutoCopy.Checked = false;
                cbAutoCopy.Enabled = false;
                cbAutoClear.Checked = false;
                cbAutoClear.Enabled = false;

            }
        }

        #endregion

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа \"Мои утилиты\" содержит ряд небольших программ, которые могут пригодится в жизни. А главное, научить меня основам программирования на C#.\nАвтор: Zerohout", "О программе");
        }

        #region Блокнот

        private void tsmiInsertDate_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortDateString());
        }

        private void tsmiInsertTime_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortTimeString());
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotepad.SaveFile("notepad.rtf");
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при сохранении.");
            }

        }

        void LoadNotepad()
        {
            try
            {
                rtbNotepad.LoadFile("notepad.rtf");
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при загрузке.");
            }
        }

        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            LoadNotepad();

        }

        #endregion

        private void btnCreatePass_Click(object sender, EventArgs e)
        {
            if (clbPass.CheckedItems.Count == 0) return;
            string password = "";
            for (int i = 0; i < nudPassLength.Value; i++)
            {
                int n = rnd.Next(0, clbPass.CheckedItems.Count);
                string s = clbPass.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Цифры":
                        password += rnd.Next(10).ToString();
                        break;
                    case "Прописные буквы":
                        password += Convert.ToChar(rnd.Next(65, 88));
                        break;
                    case "Строчные буквы":
                        password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default:
                        password += specChars[rnd.Next(specChars.Length)];
                        break;

                }
                tbPass.Text = password;
                Clipboard.SetText(password);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double m1 = metrica[cbFrom.Text];
            double m2 = metrica[cbTo.Text];
            double m3 = Convert.ToDouble(tbFrom.Text);
            tbTo.Text = (m3 * m1 / m2).ToString();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string t = cbFrom.Text;
            cbFrom.Text = cbTo.Text;
            cbTo.Text = t;
        }

        private void cbMertric_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMertric.Text)
            {
                case "длина":
                    metrica.Clear();
                    metrica.Add("mm", 1);
                    metrica.Add("cm", 10);
                    metrica.Add("dm", 100);
                    metrica.Add("m", 1000);
                    metrica.Add("km", 1000000);
                    metrica.Add("mile", 1609344);
                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("mm");
                    cbFrom.Items.Add("cm");
                    cbFrom.Items.Add("dm");
                    cbFrom.Items.Add("m");
                    cbFrom.Items.Add("km");
                    cbFrom.Items.Add("mile");
                    cbTo.Items.Clear();
                    cbTo.Items.Add("mm");
                    cbTo.Items.Add("cm");
                    cbTo.Items.Add("dm");
                    cbTo.Items.Add("m");
                    cbTo.Items.Add("km");
                    cbTo.Items.Add("mile");
                    cbFrom.Text ="mm";
                    cbTo.Text = "mm";
                    break;
                case "вес":
                    metrica.Clear();
                    metrica.Add("g", 1);
                    metrica.Add("kg", 1000);
                    metrica.Add("t", 1000000);
                    metrica.Add("lb", 453.6);
                    metrica.Add("oz", 283);
                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("g");
                    cbFrom.Items.Add("kg");
                    cbFrom.Items.Add("t");
                    cbFrom.Items.Add("lb");
                    cbFrom.Items.Add("oz");
                    cbTo.Items.Clear();
                    cbTo.Items.Add("g");
                    cbTo.Items.Add("kg");
                    cbTo.Items.Add("t");
                    cbTo.Items.Add("lb");
                    cbTo.Items.Add("oz");
                    cbFrom.Text = "g";
                    cbTo.Text = "g";
                    break;
            }
        }
    }
}
