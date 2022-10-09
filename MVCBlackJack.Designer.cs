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
        /*
        private void InicializeComponent()
        {

            this.hitButton = new System.Windows.Forms.Button(); //hitButtonConfig
            this.Jugador = new System.Windows.Forms.ListView(); //jugador
            this.Dealer = new System.Windows.Forms.ListView(); //dealer

            //dealer
            this.Dealer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.Dealer.HideSelection = false;
            //this.Dealer.Location = new System.Drawing.Point(268, 39);
            this.Dealer.Name = "Dealer";
           // this.Dealer.Size = new System.Drawing.Size(178, 265);
            this.Dealer.TabIndex = 7;
            this.Dealer.UseCompatibleStateImageBehavior = false;
            this.Dealer.View = System.Windows.Forms.View.Details;

            //Jugador
            this.Jugador.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cara1,this.Palo1, this.Valor1});
            this.Jugador.HideSelection = false;
            //this.Jugador.Location = new System.Drawing.Point(3, 39);
            this.Jugador.Name = "Jugador";
           // this.Jugador.Size = new System.Drawing.Size(178, 265);
            this.Jugador.TabIndex = 2;
            this.Jugador.UseCompatibleStateImageBehavior = false;
            this.Jugador.View = System.Windows.Forms.View.Details;
            this.Jugador.SelectedIndexChanged += new System.EventHandler(this.listMyHand_SelectedIndexChanged);
            



            //hitButton
            this.hitButton.Name = "hitButton";
            this.hitButton.TabIndex = 3;
            this.hitButton.Text = "PEDIR";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);


        }

        #region Código generado por el Diseñador de Windows Forms
        */
        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Jugador = new System.Windows.Forms.ListView();
            this.Cara1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Palo1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dealer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hitButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.Label();
            this.DealerN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Jugador
            // 
            this.Jugador.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cara1,
            this.Palo1,
            this.Valor1});
            this.Jugador.HideSelection = false;
            this.Jugador.Location = new System.Drawing.Point(25, 43);
            this.Jugador.Name = "Jugador";
            this.Jugador.Size = new System.Drawing.Size(205, 103);
            this.Jugador.TabIndex = 3;
            this.Jugador.UseCompatibleStateImageBehavior = false;
            this.Jugador.View = System.Windows.Forms.View.Details;
            this.Jugador.SelectedIndexChanged += new System.EventHandler(this.Jugador_SelectedIndexChanged);
            // 
            // Cara1
            // 
            this.Cara1.DisplayIndex = 1;
            this.Cara1.Text = "Cara";
            this.Cara1.Width = 36;
            // 
            // Palo1
            // 
            this.Palo1.DisplayIndex = 0;
            this.Palo1.Text = "Palo";
            this.Palo1.Width = 52;
            // 
            // Valor1
            // 
            this.Valor1.Text = "Value";
            this.Valor1.Width = 39;
            // 
            // Dealer
            // 
            this.Dealer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.Dealer.HideSelection = false;
            this.Dealer.Location = new System.Drawing.Point(297, 43);
            this.Dealer.Name = "Dealer";
            this.Dealer.Size = new System.Drawing.Size(207, 103);
            this.Dealer.TabIndex = 14;
            this.Dealer.Text = "Dealer";
            this.Dealer.UseCompatibleStateImageBehavior = false;
            this.Dealer.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "Cara";
            this.columnHeader1.Width = 36;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 0;
            this.columnHeader2.Text = "Palo";
            this.columnHeader2.Width = 52;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Valor";
            this.columnHeader3.Width = 39;
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(64, 218);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(75, 23);
            this.hitButton.TabIndex = 9;
            this.hitButton.Text = "PEDIR";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(196, 218);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(88, 23);
            this.stopButton.TabIndex = 10;
            this.stopButton.Text = "PLANTARSE";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(363, 214);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Iniciar/Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(244, 167);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // Player
            // 
            this.Player.AutoSize = true;
            this.Player.Location = new System.Drawing.Point(22, 18);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(45, 13);
            this.Player.TabIndex = 13;
            this.Player.Text = "Jugador";
            // 
            // DealerN
            // 
            this.DealerN.Location = new System.Drawing.Point(0, 0);
            this.DealerN.Name = "DealerN";
            this.DealerN.Size = new System.Drawing.Size(100, 23);
            this.DealerN.TabIndex = 0;
            // 
            // MVCBlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 314);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.Dealer);
            this.Controls.Add(this.Jugador);
            this.Name = "MVCBlackJack";
            this.Text = "BlackJackGame";
            this.Load += new System.EventHandler(this.MVCBlackJack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private System.Windows.Forms.ListView Jugador;
        private System.Windows.Forms.ColumnHeader Cara1;
        private System.Windows.Forms.ColumnHeader Palo1;
        private System.Windows.Forms.ColumnHeader Valor1;
        private System.Windows.Forms.ListView Dealer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label Player;
        private System.Windows.Forms.Label DealerN;
    }
}

