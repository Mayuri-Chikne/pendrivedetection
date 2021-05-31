
namespace pendrivedetection
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
            this.labelname = new System.Windows.Forms.Label();
            this.labeldriveformat = new System.Windows.Forms.Label();
            this.labeldrivetype = new System.Windows.Forms.Label();
            this.labelisready = new System.Windows.Forms.Label();
            this.labeltotalspace = new System.Windows.Forms.Label();
            this.labelfreespace = new System.Windows.Forms.Label();
            this.Buttonsubmit = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(240, 53);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(57, 20);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "Name";
            // 
            // labeldriveformat
            // 
            this.labeldriveformat.AutoSize = true;
            this.labeldriveformat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldriveformat.Location = new System.Drawing.Point(240, 99);
            this.labeldriveformat.Name = "labeldriveformat";
            this.labeldriveformat.Size = new System.Drawing.Size(114, 20);
            this.labeldriveformat.TabIndex = 1;
            this.labeldriveformat.Text = "Drive format";
            // 
            // labeldrivetype
            // 
            this.labeldrivetype.AutoSize = true;
            this.labeldrivetype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldrivetype.Location = new System.Drawing.Point(240, 146);
            this.labeldrivetype.Name = "labeldrivetype";
            this.labeldrivetype.Size = new System.Drawing.Size(100, 20);
            this.labeldrivetype.TabIndex = 2;
            this.labeldrivetype.Text = "Drive Type";
            // 
            // labelisready
            // 
            this.labelisready.AutoSize = true;
            this.labelisready.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelisready.Location = new System.Drawing.Point(242, 189);
            this.labelisready.Name = "labelisready";
            this.labelisready.Size = new System.Drawing.Size(82, 20);
            this.labelisready.TabIndex = 3;
            this.labelisready.Text = "Is Ready";
            // 
            // labeltotalspace
            // 
            this.labeltotalspace.AutoSize = true;
            this.labeltotalspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotalspace.Location = new System.Drawing.Point(240, 229);
            this.labeltotalspace.Name = "labeltotalspace";
            this.labeltotalspace.Size = new System.Drawing.Size(109, 20);
            this.labeltotalspace.TabIndex = 4;
            this.labeltotalspace.Text = "Total Space";
            // 
            // labelfreespace
            // 
            this.labelfreespace.AutoSize = true;
            this.labelfreespace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfreespace.Location = new System.Drawing.Point(240, 279);
            this.labelfreespace.Name = "labelfreespace";
            this.labelfreespace.Size = new System.Drawing.Size(105, 20);
            this.labelfreespace.TabIndex = 5;
            this.labelfreespace.Text = "Free Space";
            // 
            // Buttonsubmit
            // 
            this.Buttonsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buttonsubmit.Location = new System.Drawing.Point(325, 348);
            this.Buttonsubmit.Name = "Buttonsubmit";
            this.Buttonsubmit.Size = new System.Drawing.Size(335, 40);
            this.Buttonsubmit.TabIndex = 6;
            this.Buttonsubmit.Text = "Show Pendrive Detail";
            this.Buttonsubmit.UseVisualStyleBackColor = true;
            this.Buttonsubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(876, 446);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(162, 46);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "excelview";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 547);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Buttonsubmit);
            this.Controls.Add(this.labelfreespace);
            this.Controls.Add(this.labeltotalspace);
            this.Controls.Add(this.labelisready);
            this.Controls.Add(this.labeldrivetype);
            this.Controls.Add(this.labeldriveformat);
            this.Controls.Add(this.labelname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labeldriveformat;
        private System.Windows.Forms.Label labeldrivetype;
        private System.Windows.Forms.Label labelisready;
        private System.Windows.Forms.Label labeltotalspace;
        private System.Windows.Forms.Label labelfreespace;
        private System.Windows.Forms.Button Buttonsubmit;
        private System.Windows.Forms.Button Button1;
    }
}

