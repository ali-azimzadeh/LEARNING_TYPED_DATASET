
namespace LEARNING_TYPED_DATASET.UI
{
    partial class SampleForm
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
            this.GetDataButton = new System.Windows.Forms.Button();
            this.CardNoLabel = new System.Windows.Forms.Label();
            this.CardNoTextBox = new System.Windows.Forms.TextBox();
            this.DailyDoinsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DailyDoinsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GetDataButton
            // 
            this.GetDataButton.Enabled = false;
            this.GetDataButton.Location = new System.Drawing.Point(20, 130);
            this.GetDataButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(739, 48);
            this.GetDataButton.TabIndex = 0;
            this.GetDataButton.Text = "Get Data By CardNo";
            this.GetDataButton.UseVisualStyleBackColor = true;
            this.GetDataButton.Click += new System.EventHandler(this.GetDataButton_Click);
            // 
            // CardNoLabel
            // 
            this.CardNoLabel.AutoSize = true;
            this.CardNoLabel.Location = new System.Drawing.Point(661, 51);
            this.CardNoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CardNoLabel.Name = "CardNoLabel";
            this.CardNoLabel.Size = new System.Drawing.Size(83, 27);
            this.CardNoLabel.TabIndex = 1;
            this.CardNoLabel.Text = "شماره کارت";
            // 
            // CardNoTextBox
            // 
            this.CardNoTextBox.Location = new System.Drawing.Point(20, 48);
            this.CardNoTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CardNoTextBox.Name = "CardNoTextBox";
            this.CardNoTextBox.Size = new System.Drawing.Size(621, 35);
            this.CardNoTextBox.TabIndex = 2;
            this.CardNoTextBox.TextChanged += new System.EventHandler(this.CardNoTextBox_TextChanged);
            // 
            // DailyDoinsDataGridView
            // 
            this.DailyDoinsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DailyDoinsDataGridView.Location = new System.Drawing.Point(20, 219);
            this.DailyDoinsDataGridView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DailyDoinsDataGridView.Name = "DailyDoinsDataGridView";
            this.DailyDoinsDataGridView.Size = new System.Drawing.Size(739, 407);
            this.DailyDoinsDataGridView.TabIndex = 3;
            // 
            // SampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 650);
            this.Controls.Add(this.DailyDoinsDataGridView);
            this.Controls.Add(this.CardNoTextBox);
            this.Controls.Add(this.CardNoLabel);
            this.Controls.Add(this.GetDataButton);
            this.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SampleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SampleForm";
            ((System.ComponentModel.ISupportInitialize)(this.DailyDoinsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetDataButton;
        private System.Windows.Forms.Label CardNoLabel;
        private System.Windows.Forms.TextBox CardNoTextBox;
        private System.Windows.Forms.DataGridView DailyDoinsDataGridView;
    }
}