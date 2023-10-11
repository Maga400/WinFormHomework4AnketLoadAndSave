using System.Text.RegularExpressions;
using System.Text.Json;
using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        class Anket
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Birthday { get; set; }
            public Anket(string name, string surname, string email, string phone, string birthday)
            {
                Name = name;
                Surname = surname;
                Email = email;
                Phone = phone;
                Birthday = birthday;
            }

            public override string ToString()
            {
                return Name.ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        int check = 0;
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<Anket> ankets = new List<Anket>();
        private void addButton_Click(object sender, EventArgs e)
        {
            string pattern = @"(^\+994) \((055|050|070|077|010|099)\)\s(\d{3})\s(\d{2})\s(\d{2})$";

            if (nameTextBox.Text.Length >= 3 && surnameTextBox.Text.Length >= 5 && emailTextBox.Text.EndsWith("@gmail.com") && Regex.IsMatch(phoneTextBox.Text, pattern) && emailTextBox.Text.Length >= 16)
            {

                Anket anket = new Anket(nameTextBox.Text, surnameTextBox.Text, emailTextBox.Text, phoneTextBox.Text, BirthdayPicker.Text);
                ankets.Add(anket);
                listBox1.Items.Clear();
                foreach (var item in ankets)
                {
                    listBox1.Items.Add(item);
                }
                Thread.Sleep(100);
                Clean();
            }

            else if (nameTextBox.Text.Length < 3)
            {
                MessageBox.Show("Invalid name!!!Sizin adiniz minumum 3 herf olmalidir", "NAME WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (surnameTextBox.Text.Length < 5)
            {
                MessageBox.Show("Invalid surname!!!Sizin soyadiniz minumum 5 herf olmalidir", "SURNAME WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (emailTextBox.Text.EndsWith("@gmail.com") == false)
            {
                MessageBox.Show("Invalid email!!!Sizin emailinizin sonu @gmail.comla olmalidir", "EMAIL WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (emailTextBox.Text.Length < 16)
            {
                MessageBox.Show("Invalid email!!!Sizin email adiniz en azi 6 simvol olmalidir", "EMAIL WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (Regex.IsMatch(phoneTextBox.Text, pattern) == false)
            {
                MessageBox.Show("Invalid phone!!!Sizin phone numberiniz duzgun olmalidir", "PHONE WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            var index = listBox1.SelectedIndex;

            nameTextBox.Text = ankets[index].Name;
            surnameTextBox.Text = ankets[index].Surname;
            emailTextBox.Text = ankets[index].Email;
            phoneTextBox.Text = ankets[index].Phone;
            BirthdayPicker.Text = ankets[index].Birthday;
            ankets.Remove(ankets[index]);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count != 0 && fileNameTextBox.Text.Length != 0)
            {

                if (!fileNameTextBox.Text.EndsWith(".json"))
                {
                    fileNameTextBox.Text += ".json";
                }

                if (File.Exists(fileNameTextBox.Text) && check==0)
                {
                    MessageBox.Show("Invalid file name!!!Sizin daxil etdiyiniz file adinda file movcuddur", "FILE NAME WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (check==1) 
                {
                    var json = JsonSerializer.Serialize(ankets);
                    File.WriteAllText(fileNameTextBox.Text, json);
                    Thread.Sleep(100);
                    listBox1.Items.Clear();
                    Clean();
                    ankets.Clear();
                    fileNameTextBox.Text = "";
                    check = 0;
                }
                else if (check==0)
                {
                    var json = JsonSerializer.Serialize(ankets);
                    File.WriteAllText(fileNameTextBox.Text, json);
                    Thread.Sleep(100);
                    listBox1.Items.Clear();
                    Clean();
                    ankets.Clear();
                    fileNameTextBox.Text = "";
                }
            }


            else if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Invalid anket!!!Sizin listboxsunuzda anket yoxdur", "ANKET WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (fileNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Invalid file name!!!Siz file adin daxil etmemisiniz", "FILE NAME WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
        public void Clean()
        {
            nameTextBox.Text = "";
            surnameTextBox.Text = "";
            emailTextBox.Text = "";
            phoneTextBox.Text = "";
            BirthdayPicker.Text = "";
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (fileNameTextBox.Text.Length != 0)
            {

                if (!fileNameTextBox.Text.EndsWith(".json"))
                {
                    fileNameTextBox.Text += ".json";
                }

                if (!File.Exists(fileNameTextBox.Text))
                {
                    MessageBox.Show("Invalid file name!!!Sizin daxil etdiyiniz file adinda file yoxdur", "FILE NAME WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fileNameTextBox.Text = "";
                }

                else
                {
                    Thread.Sleep(100);
                    listBox1.Items.Clear();
                    Clean();
                    ankets.Clear();

                    check++;

                    var json = File.ReadAllText(fileNameTextBox.Text);
                    ankets = JsonSerializer.Deserialize<List<Anket>>(json);
                    foreach (var item in ankets)
                    {
                        listBox1.Items.Add(item);
                    }
                    fileNameTextBox.Text = "";
                }
            }

            else if (fileNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Invalid file name!!!Siz file adin daxil etmemisiniz", "FILE NAME WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}