using Newtonsoft.Json;
using NoteApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class NoteApp : Form
    {
        DataTable data;
        public NoteApp()
        {
            InitializeComponent();
        }

        private void NoteApp_Load(object sender, EventArgs e)
        {
            data = new DataTable();

            data.Columns.Add("Title", typeof(string));
            data.Columns.Add("Text", typeof(string));

            LoadData();

            ClearTextArea();

            dataGridView1.DataSource = data;
            dataGridView1.Columns["Text"].Visible = false;
        }

        protected override void OnClosed(EventArgs e)
        {
            var notesToSave = new List<Note>();

            foreach (DataRow rowData in data.Rows)
            {
                var note = new Note(rowData.ItemArray[0].ToString(), rowData.ItemArray[1].ToString());
                notesToSave.Add(note);
            }

            var json = JsonConvert.SerializeObject(notesToSave);

            using (var file = File.Open("storage.json", FileMode.Create))
            {
                StreamWriter x = new StreamWriter(file);
                x.WriteLine(json);
                x.Close();
            }

            base.OnClosed(e);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Title.Text) && string.IsNullOrEmpty(NoteText.Text) ) 
            {
                MessageBox
               .Show("Note cannot be save whitout title and text!", "Saving note error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(Title.Text))
            {
                MessageBox
              .Show("Note without a title cannot be saved!", "Saving note error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                data.Rows.Add(Title.Text, NoteText.Text);
                ClearTextArea();
            }

        }
        private void LoadNote_Click(object sender, EventArgs e)
        {
            int index = CurrentIndexFromDataGridView();

            if (index >= 0)
            {
                Title.Text = data.Rows[index].ItemArray[0].ToString();
                NoteText.Text = data.Rows[index].ItemArray[1].ToString();
            }
        }
        private void DeleteNote_Click(object sender, EventArgs e)
        {
            int index = CurrentIndexFromDataGridView();

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result =
                MessageBox
                .Show("Do you want to delete the note?", "Delete note", buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                data.Rows[index].Delete();
            }

        }
        private void ClearTextArea()
        {
            Title.Text = string.Empty;
            NoteText.Text = string.Empty;
        }
        private int CurrentIndexFromDataGridView()
        {
            return dataGridView1.CurrentCell.RowIndex;
        }
        private void LoadData()
        {
            string json =string.Empty;

            using (var file = File.Open("storage.json",FileMode.OpenOrCreate))
            {
                StreamReader x = new StreamReader(file);
                json= x.ReadToEnd();
                x.Close();
            }

            if (!string.IsNullOrEmpty(json))
            {
                var notes = JsonConvert.DeserializeObject<List<Note>>(json);

                foreach (var note in notes)
                {
                    data.Rows.Add(note.Title, note.Text);
                }
            }
        }
    }
}
