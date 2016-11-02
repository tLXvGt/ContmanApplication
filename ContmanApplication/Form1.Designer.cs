namespace ContmanApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.previewTextBox = new System.Windows.Forms.TextBox();
            this.statisticsGroupBox = new System.Windows.Forms.GroupBox();
            this.threeMostFrequentCharsTextBox = new System.Windows.Forms.TextBox();
            this.averageWordsInSentenceTextBox = new System.Windows.Forms.TextBox();
            this.averageLettersInWordTextBox = new System.Windows.Forms.TextBox();
            this.paragraphCountTextBox = new System.Windows.Forms.TextBox();
            this.sentenceCountTextBox = new System.Windows.Forms.TextBox();
            this.wordCountTextBox = new System.Windows.Forms.TextBox();
            this.charCountTextBox = new System.Windows.Forms.TextBox();
            this.threeMostFrequentCharsLabel = new System.Windows.Forms.Label();
            this.averageWordsInSentenceLabel = new System.Windows.Forms.Label();
            this.averageLettersInWordLabel = new System.Windows.Forms.Label();
            this.paragraphCountLabel = new System.Windows.Forms.Label();
            this.sentenceCountLabel = new System.Windows.Forms.Label();
            this.wordCountLabel = new System.Windows.Forms.Label();
            this.charCountLabel = new System.Windows.Forms.Label();
            this.previewLabel = new System.Windows.Forms.Label();
            this.statisticsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // loadFileButton
            // 
            this.loadFileButton.Location = new System.Drawing.Point(12, 12);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(75, 23);
            this.loadFileButton.TabIndex = 0;
            this.loadFileButton.Text = "Wczytaj plik";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // previewTextBox
            // 
            this.previewTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.previewTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewTextBox.Location = new System.Drawing.Point(12, 54);
            this.previewTextBox.Multiline = true;
            this.previewTextBox.Name = "previewTextBox";
            this.previewTextBox.ReadOnly = true;
            this.previewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.previewTextBox.Size = new System.Drawing.Size(371, 121);
            this.previewTextBox.TabIndex = 1;
            // 
            // statisticsGroupBox
            // 
            this.statisticsGroupBox.Controls.Add(this.threeMostFrequentCharsTextBox);
            this.statisticsGroupBox.Controls.Add(this.averageWordsInSentenceTextBox);
            this.statisticsGroupBox.Controls.Add(this.averageLettersInWordTextBox);
            this.statisticsGroupBox.Controls.Add(this.paragraphCountTextBox);
            this.statisticsGroupBox.Controls.Add(this.sentenceCountTextBox);
            this.statisticsGroupBox.Controls.Add(this.wordCountTextBox);
            this.statisticsGroupBox.Controls.Add(this.charCountTextBox);
            this.statisticsGroupBox.Controls.Add(this.threeMostFrequentCharsLabel);
            this.statisticsGroupBox.Controls.Add(this.averageWordsInSentenceLabel);
            this.statisticsGroupBox.Controls.Add(this.averageLettersInWordLabel);
            this.statisticsGroupBox.Controls.Add(this.paragraphCountLabel);
            this.statisticsGroupBox.Controls.Add(this.sentenceCountLabel);
            this.statisticsGroupBox.Controls.Add(this.wordCountLabel);
            this.statisticsGroupBox.Controls.Add(this.charCountLabel);
            this.statisticsGroupBox.Location = new System.Drawing.Point(12, 200);
            this.statisticsGroupBox.Name = "statisticsGroupBox";
            this.statisticsGroupBox.Size = new System.Drawing.Size(371, 223);
            this.statisticsGroupBox.TabIndex = 2;
            this.statisticsGroupBox.TabStop = false;
            this.statisticsGroupBox.Text = "Statystyki";
            // 
            // threeMostFrequentCharsTextBox
            // 
            this.threeMostFrequentCharsTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.threeMostFrequentCharsTextBox.Location = new System.Drawing.Point(194, 187);
            this.threeMostFrequentCharsTextBox.Name = "threeMostFrequentCharsTextBox";
            this.threeMostFrequentCharsTextBox.ReadOnly = true;
            this.threeMostFrequentCharsTextBox.Size = new System.Drawing.Size(171, 20);
            this.threeMostFrequentCharsTextBox.TabIndex = 13;
            // 
            // averageWordsInSentenceTextBox
            // 
            this.averageWordsInSentenceTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.averageWordsInSentenceTextBox.Location = new System.Drawing.Point(194, 159);
            this.averageWordsInSentenceTextBox.Name = "averageWordsInSentenceTextBox";
            this.averageWordsInSentenceTextBox.ReadOnly = true;
            this.averageWordsInSentenceTextBox.Size = new System.Drawing.Size(171, 20);
            this.averageWordsInSentenceTextBox.TabIndex = 12;
            // 
            // averageLettersInWordTextBox
            // 
            this.averageLettersInWordTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.averageLettersInWordTextBox.Location = new System.Drawing.Point(194, 131);
            this.averageLettersInWordTextBox.Name = "averageLettersInWordTextBox";
            this.averageLettersInWordTextBox.ReadOnly = true;
            this.averageLettersInWordTextBox.Size = new System.Drawing.Size(171, 20);
            this.averageLettersInWordTextBox.TabIndex = 11;
            // 
            // paragraphCountTextBox
            // 
            this.paragraphCountTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paragraphCountTextBox.Location = new System.Drawing.Point(194, 103);
            this.paragraphCountTextBox.Name = "paragraphCountTextBox";
            this.paragraphCountTextBox.ReadOnly = true;
            this.paragraphCountTextBox.Size = new System.Drawing.Size(171, 20);
            this.paragraphCountTextBox.TabIndex = 10;
            // 
            // sentenceCountTextBox
            // 
            this.sentenceCountTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sentenceCountTextBox.Location = new System.Drawing.Point(194, 75);
            this.sentenceCountTextBox.Name = "sentenceCountTextBox";
            this.sentenceCountTextBox.ReadOnly = true;
            this.sentenceCountTextBox.Size = new System.Drawing.Size(171, 20);
            this.sentenceCountTextBox.TabIndex = 9;
            // 
            // wordCountTextBox
            // 
            this.wordCountTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wordCountTextBox.Location = new System.Drawing.Point(194, 47);
            this.wordCountTextBox.Name = "wordCountTextBox";
            this.wordCountTextBox.ReadOnly = true;
            this.wordCountTextBox.Size = new System.Drawing.Size(171, 20);
            this.wordCountTextBox.TabIndex = 8;
            // 
            // charCountTextBox
            // 
            this.charCountTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.charCountTextBox.Location = new System.Drawing.Point(194, 19);
            this.charCountTextBox.Name = "charCountTextBox";
            this.charCountTextBox.ReadOnly = true;
            this.charCountTextBox.Size = new System.Drawing.Size(171, 20);
            this.charCountTextBox.TabIndex = 7;
            // 
            // threeMostFrequentCharsLabel
            // 
            this.threeMostFrequentCharsLabel.AutoSize = true;
            this.threeMostFrequentCharsLabel.Location = new System.Drawing.Point(9, 190);
            this.threeMostFrequentCharsLabel.Name = "threeMostFrequentCharsLabel";
            this.threeMostFrequentCharsLabel.Size = new System.Drawing.Size(113, 13);
            this.threeMostFrequentCharsLabel.TabIndex = 6;
            this.threeMostFrequentCharsLabel.Text = "Trzy najczęstsze znaki";
            // 
            // averageWordsInSentenceLabel
            // 
            this.averageWordsInSentenceLabel.AutoSize = true;
            this.averageWordsInSentenceLabel.Location = new System.Drawing.Point(9, 162);
            this.averageWordsInSentenceLabel.Name = "averageWordsInSentenceLabel";
            this.averageWordsInSentenceLabel.Size = new System.Drawing.Size(156, 13);
            this.averageWordsInSentenceLabel.TabIndex = 5;
            this.averageWordsInSentenceLabel.Text = "Średnia ilość wyrazów w zdaniu";
            // 
            // averageLettersInWordLabel
            // 
            this.averageLettersInWordLabel.AutoSize = true;
            this.averageLettersInWordLabel.Location = new System.Drawing.Point(9, 134);
            this.averageLettersInWordLabel.Name = "averageLettersInWordLabel";
            this.averageLettersInWordLabel.Size = new System.Drawing.Size(135, 13);
            this.averageLettersInWordLabel.TabIndex = 4;
            this.averageLettersInWordLabel.Text = "Średnia ilość liter w wyrazie";
            // 
            // paragraphCountLabel
            // 
            this.paragraphCountLabel.AutoSize = true;
            this.paragraphCountLabel.Location = new System.Drawing.Point(9, 106);
            this.paragraphCountLabel.Name = "paragraphCountLabel";
            this.paragraphCountLabel.Size = new System.Drawing.Size(75, 13);
            this.paragraphCountLabel.TabIndex = 3;
            this.paragraphCountLabel.Text = "Ilość akapitów";
            // 
            // sentenceCountLabel
            // 
            this.sentenceCountLabel.AutoSize = true;
            this.sentenceCountLabel.Location = new System.Drawing.Point(9, 78);
            this.sentenceCountLabel.Name = "sentenceCountLabel";
            this.sentenceCountLabel.Size = new System.Drawing.Size(55, 13);
            this.sentenceCountLabel.TabIndex = 2;
            this.sentenceCountLabel.Text = "Ilość zdań";
            // 
            // wordCountLabel
            // 
            this.wordCountLabel.AutoSize = true;
            this.wordCountLabel.Location = new System.Drawing.Point(9, 50);
            this.wordCountLabel.Name = "wordCountLabel";
            this.wordCountLabel.Size = new System.Drawing.Size(73, 13);
            this.wordCountLabel.TabIndex = 1;
            this.wordCountLabel.Text = "Ilość wyrazów";
            // 
            // charCountLabel
            // 
            this.charCountLabel.AutoSize = true;
            this.charCountLabel.Location = new System.Drawing.Point(9, 22);
            this.charCountLabel.Name = "charCountLabel";
            this.charCountLabel.Size = new System.Drawing.Size(69, 13);
            this.charCountLabel.TabIndex = 0;
            this.charCountLabel.Text = "Ilość znaków";
            // 
            // previewLabel
            // 
            this.previewLabel.AutoSize = true;
            this.previewLabel.Location = new System.Drawing.Point(9, 38);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(46, 13);
            this.previewLabel.TabIndex = 3;
            this.previewLabel.Text = "Podgląd";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 434);
            this.Controls.Add(this.previewLabel);
            this.Controls.Add(this.statisticsGroupBox);
            this.Controls.Add(this.previewTextBox);
            this.Controls.Add(this.loadFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.statisticsGroupBox.ResumeLayout(false);
            this.statisticsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.TextBox previewTextBox;
        private System.Windows.Forms.GroupBox statisticsGroupBox;
        private System.Windows.Forms.Label sentenceCountLabel;
        private System.Windows.Forms.Label wordCountLabel;
        private System.Windows.Forms.Label charCountLabel;
        private System.Windows.Forms.Label threeMostFrequentCharsLabel;
        private System.Windows.Forms.Label averageWordsInSentenceLabel;
        private System.Windows.Forms.Label averageLettersInWordLabel;
        private System.Windows.Forms.Label paragraphCountLabel;
        private System.Windows.Forms.TextBox threeMostFrequentCharsTextBox;
        private System.Windows.Forms.TextBox averageWordsInSentenceTextBox;
        private System.Windows.Forms.TextBox averageLettersInWordTextBox;
        private System.Windows.Forms.TextBox paragraphCountTextBox;
        private System.Windows.Forms.TextBox sentenceCountTextBox;
        private System.Windows.Forms.TextBox wordCountTextBox;
        private System.Windows.Forms.TextBox charCountTextBox;
        private System.Windows.Forms.Label previewLabel;
    }
}

