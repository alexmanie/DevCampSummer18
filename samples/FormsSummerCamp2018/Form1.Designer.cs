namespace WindowsFormsApp1
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
            this.btnGetData = new System.Windows.Forms.Button();
            this.gridUnderImputed = new System.Windows.Forms.DataGridView();
            this.gridOverImputed = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnderImputed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOverImputed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(26, 42);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(156, 35);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "GetData";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // gridUnderImputed
            // 
            this.gridUnderImputed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUnderImputed.Location = new System.Drawing.Point(679, 42);
            this.gridUnderImputed.Name = "gridUnderImputed";
            this.gridUnderImputed.RowTemplate.Height = 28;
            this.gridUnderImputed.Size = new System.Drawing.Size(429, 369);
            this.gridUnderImputed.TabIndex = 3;
            // 
            // gridOverImputed
            // 
            this.gridOverImputed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOverImputed.Location = new System.Drawing.Point(219, 42);
            this.gridOverImputed.Name = "gridOverImputed";
            this.gridOverImputed.RowTemplate.Height = 28;
            this.gridOverImputed.Size = new System.Drawing.Size(429, 369);
            this.gridOverImputed.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 450);
            this.Controls.Add(this.gridOverImputed);
            this.Controls.Add(this.gridUnderImputed);
            this.Controls.Add(this.btnGetData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridUnderImputed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOverImputed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.DataGridView gridUnderImputed;
        private System.Windows.Forms.DataGridView gridOverImputed;
    }
}

