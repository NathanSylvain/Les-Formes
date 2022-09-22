namespace ExerciceSomatif2.Controles
{
    partial class DessinControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.picForme = new System.Windows.Forms.PictureBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picForme)).BeginInit();
            this.SuspendLayout();
            // 
            // picForme
            // 
            this.picForme.Location = new System.Drawing.Point(134, 81);
            this.picForme.Name = "picForme";
            this.picForme.Size = new System.Drawing.Size(235, 206);
            this.picForme.TabIndex = 0;
            this.picForme.TabStop = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(127, 37);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(55, 25);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type:";
            // 
            // lblAType
            // 
            this.lblAType.AutoSize = true;
            this.lblAType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAType.Location = new System.Drawing.Point(236, 37);
            this.lblAType.Name = "lblAType";
            this.lblAType.Size = new System.Drawing.Size(133, 25);
            this.lblAType.TabIndex = 2;
            this.lblAType.Text = "Affichage type";
            // 
            // DessinControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.picForme);
            this.Name = "DessinControl";
            this.Size = new System.Drawing.Size(548, 312);
            ((System.ComponentModel.ISupportInitialize)(this.picForme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picForme;
        private Label lblType;
        private Label lblAType;

    }
}
