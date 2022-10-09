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
            this.Jugador = new System.Windows.Forms.ListView();
            this.FaceM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuitM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listDealerHand = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hitButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Jugador
            // 
            this.Jugador.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FaceM,
            this.SuitM,
            this.ValueM});
            this.Jugador.HideSelection = false;
            this.Jugador.Location = new System.Drawing.Point(25, 43);
            this.Jugador.Name = "Jugador";
            this.Jugador.Size = new System.Drawing.Size(205, 103);
            this.Jugador.TabIndex = 3;
            this.Jugador.UseCompatibleStateImageBehavior = false;
            this.Jugador.View = System.Windows.Forms.View.Details;
            this.Jugador.SelectedIndexChanged += new System.EventHandler(this.listMyHand_SelectedIndexChanged);
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
            // listDealerHand
            // 
            this.listDealerHand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listDealerHand.HideSelection = false;
            this.listDealerHand.Location = new System.Drawing.Point(288, 43);
            this.listDealerHand.Name = "listDealerHand";
            this.listDealerHand.Size = new System.Drawing.Size(205, 103);
            this.listDealerHand.TabIndex = 8;
            this.listDealerHand.UseCompatibleStateImageBehavior = false;
            this.listDealerHand.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "Face";
            this.columnHeader1.Width = 36;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 0;
            this.columnHeader2.Text = "Suit";
            this.columnHeader2.Width = 52;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value";
            this.columnHeader3.Width = 39;
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(64, 218);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(75, 23);
            this.hitButton.TabIndex = 9;
            this.hitButton.Text = "HIT ME!";
            this.hitButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(196, 218);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 10;
            this.stopButton.Text = "STOP!";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(363, 214);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Start/Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(244, 167);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Text = "Partida";
            // 
            // MVCBlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 314);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.listDealerHand);
            this.Controls.Add(this.Jugador);
            this.Name = "MVCBlackJack";
            this.Text = "BlackJackGame";
            this.Load += new System.EventHandler(this.MVCBlackJack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Jugador;
        private System.Windows.Forms.ColumnHeader FaceM;
        private System.Windows.Forms.ColumnHeader SuitM;
        private System.Windows.Forms.ColumnHeader ValueM;
        private System.Windows.Forms.ListView listDealerHand;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label statusLabel;
    }
}

