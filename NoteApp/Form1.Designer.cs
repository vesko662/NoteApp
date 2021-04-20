
namespace NoteApp
{
    partial class NoteApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NoteText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NoteShower = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadNote = new System.Windows.Forms.Button();
            this.DeleteNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NoteShower)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(119, 80);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(192, 27);
            this.Title.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // NoteText
            // 
            this.NoteText.Location = new System.Drawing.Point(119, 141);
            this.NoteText.Name = "NoteText";
            this.NoteText.Size = new System.Drawing.Size(192, 164);
            this.NoteText.TabIndex = 2;
            this.NoteText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(164, 334);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 29);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // NoteShower
            // 
            this.NoteShower.AllowUserToAddRows = false;
            this.NoteShower.AllowUserToDeleteRows = false;
            this.NoteShower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NoteShower.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.NoteShower.Location = new System.Drawing.Point(437, 80);
            this.NoteShower.Name = "NoteShower";
            this.NoteShower.ReadOnly = true;
            this.NoteShower.RowHeadersVisible = false;
            this.NoteShower.RowHeadersWidth = 51;
            this.NoteShower.RowTemplate.Height = 29;
            this.NoteShower.Size = new System.Drawing.Size(216, 225);
            this.NoteShower.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // LoadNote
            // 
            this.LoadNote.Location = new System.Drawing.Point(437, 334);
            this.LoadNote.Name = "LoadNote";
            this.LoadNote.Size = new System.Drawing.Size(94, 29);
            this.LoadNote.TabIndex = 6;
            this.LoadNote.Text = "Load";
            this.LoadNote.UseVisualStyleBackColor = true;
            // 
            // DeleteNote
            // 
            this.DeleteNote.Location = new System.Drawing.Point(559, 334);
            this.DeleteNote.Name = "DeleteNote";
            this.DeleteNote.Size = new System.Drawing.Size(94, 29);
            this.DeleteNote.TabIndex = 7;
            this.DeleteNote.Text = "Delete";
            this.DeleteNote.UseVisualStyleBackColor = true;
            // 
            // NoteApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.DeleteNote);
            this.Controls.Add(this.LoadNote);
            this.Controls.Add(this.NoteShower);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NoteText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Name = "NoteApp";
            this.Text = "NoteApp";
            ((System.ComponentModel.ISupportInitialize)(this.NoteShower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox NoteText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView NoteShower;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button LoadNote;
        private System.Windows.Forms.Button DeleteNote;
    }
}

