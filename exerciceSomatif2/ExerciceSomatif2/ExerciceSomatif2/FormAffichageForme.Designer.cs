namespace ExerciceSomatif2
{
    partial class FormAffichageForme
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
            this.btnChanger = new System.Windows.Forms.Button();
            this.dessinControl1 = new ExerciceSomatif2.Controles.DessinControl();
            this.SuspendLayout();
            // 
            // btnChanger
            // 
            this.btnChanger.Location = new System.Drawing.Point(171, 331);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(177, 46);
            this.btnChanger.TabIndex = 6;
            this.btnChanger.Text = "Changer";
            this.btnChanger.UseVisualStyleBackColor = true;
            this.btnChanger.Click += new System.EventHandler(this.btnChanger_Click);
            // 
            // dessinControl1
            // 
         
            this.dessinControl1.Location = new System.Drawing.Point(-11, 12);
            this.dessinControl1.Name = "dessinControl1";
            this.dessinControl1.Size = new System.Drawing.Size(548, 300);
            this.dessinControl1.TabIndex = 7;
            // 
            // FormAffichageForme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 411);
            this.Controls.Add(this.dessinControl1);
            this.Controls.Add(this.btnChanger);
            this.Name = "FormAffichageForme";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnChanger;
        private Controles.DessinControl dessinControl1;
    }
}