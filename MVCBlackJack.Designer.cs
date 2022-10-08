namespace BlackJackGame
{
    partial class MVCBlackJack
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listMyHand = new System.Windows.Forms.ListView();
            this.FaceM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuitM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listMyHand
            // 
            this.listMyHand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FaceM,
            this.SuitM,
            this.ValueM});
            this.listMyHand.HideSelection = false;
            this.listMyHand.Location = new System.Drawing.Point(53, 12);
            this.listMyHand.Name = "listMyHand";
            this.listMyHand.Size = new System.Drawing.Size(205, 103);
            this.listMyHand.TabIndex = 3;
            this.listMyHand.UseCompatibleStateImageBehavior = false;
            this.listMyHand.View = System.Windows.Forms.View.Details;
            this.listMyHand.SelectedIndexChanged += new System.EventHandler(this.listMyHand_SelectedIndexChanged);
            // 
            // FaceM
            // 
            this.FaceM.DisplayIndex = 1;
            this.FaceM.Text = "Face";
            this.FaceM.Width = 36;
            // 
            // SuitM
            // 
            this.SuitM.DisplayIndex = 0;
            this.SuitM.Text = "Suit";
            this.SuitM.Width = 52;
            // 
            // ValueM
            // 
            this.ValueM.Text = "Value";
            this.ValueM.Width = 39;
            // 
            // MVCBlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listMyHand);
            this.Name = "MVCBlackJack";
            this.Text = "BlackJackGame";
            this.Load += new System.EventHandler(this.MVCBlackJack_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listMyHand;
        private System.Windows.Forms.ColumnHeader FaceM;
        private System.Windows.Forms.ColumnHeader SuitM;
        private System.Windows.Forms.ColumnHeader ValueM;
    }
}

