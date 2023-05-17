namespace PICAS_Y_FIJAS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            BTNVALIDAR = new Button();
            BTNREINICIAR = new Button();
            TXTNUMERO = new TextBox();
            BTNGENERAR = new Button();
            label3 = new Label();
            LBLPICAS = new Label();
            LBLFIJAS = new Label();
            NUMEROALBL = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(217, 39);
            label1.Name = "label1";
            label1.Size = new Size(337, 71);
            label1.TabIndex = 0;
            label1.Text = "PICAS Y FIJAS";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(24, 110);
            label2.Name = "label2";
            label2.Size = new Size(733, 130);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BTNVALIDAR
            // 
            BTNVALIDAR.Location = new Point(284, 337);
            BTNVALIDAR.Name = "BTNVALIDAR";
            BTNVALIDAR.Size = new Size(112, 34);
            BTNVALIDAR.TabIndex = 2;
            BTNVALIDAR.Text = "Validar";
            BTNVALIDAR.UseVisualStyleBackColor = true;
            BTNVALIDAR.Click += BTNVALIDAR_Click;
            // 
            // BTNREINICIAR
            // 
            BTNREINICIAR.Location = new Point(423, 337);
            BTNREINICIAR.Name = "BTNREINICIAR";
            BTNREINICIAR.Size = new Size(112, 34);
            BTNREINICIAR.TabIndex = 3;
            BTNREINICIAR.Text = "REINICIAR";
            BTNREINICIAR.UseVisualStyleBackColor = true;
            BTNREINICIAR.Click += BTNREINICIAR_Click;
            // 
            // TXTNUMERO
            // 
            TXTNUMERO.Location = new Point(284, 276);
            TXTNUMERO.Name = "TXTNUMERO";
            TXTNUMERO.Size = new Size(150, 31);
            TXTNUMERO.TabIndex = 4;
            TXTNUMERO.TextChanged += TXTNUMERO_TextChanged;
            // 
            // BTNGENERAR
            // 
            BTNGENERAR.Location = new Point(88, 337);
            BTNGENERAR.Name = "BTNGENERAR";
            BTNGENERAR.Size = new Size(163, 34);
            BTNGENERAR.TabIndex = 5;
            BTNGENERAR.Text = "Generar Numero Aleatorio";
            BTNGENERAR.UseVisualStyleBackColor = true;
            BTNGENERAR.Click += BTNGENERAR_Click;
            // 
            // label3
            // 
            label3.Location = new Point(50, 276);
            label3.Name = "label3";
            label3.Size = new Size(228, 31);
            label3.TabIndex = 6;
            label3.Text = "Introduce tu numero aqui";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LBLPICAS
            // 
            LBLPICAS.Location = new Point(482, 240);
            LBLPICAS.Name = "LBLPICAS";
            LBLPICAS.Size = new Size(228, 31);
            LBLPICAS.TabIndex = 7;
            LBLPICAS.Text = "PICAS :";
            LBLPICAS.TextAlign = ContentAlignment.MiddleCenter;
            LBLPICAS.Click += label4_Click;
            // 
            // LBLFIJAS
            // 
            LBLFIJAS.Location = new Point(482, 276);
            LBLFIJAS.Name = "LBLFIJAS";
            LBLFIJAS.Size = new Size(228, 31);
            LBLFIJAS.TabIndex = 8;
            LBLFIJAS.Text = "FIJAS: ";
            LBLFIJAS.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NUMEROALBL
            // 
            NUMEROALBL.Location = new Point(541, 340);
            NUMEROALBL.Name = "NUMEROALBL";
            NUMEROALBL.Size = new Size(228, 31);
            NUMEROALBL.TabIndex = 9;
            NUMEROALBL.Text = "NUMERO ALEATORIO: ";
            NUMEROALBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NUMEROALBL);
            Controls.Add(LBLFIJAS);
            Controls.Add(LBLPICAS);
            Controls.Add(label3);
            Controls.Add(BTNGENERAR);
            Controls.Add(TXTNUMERO);
            Controls.Add(BTNREINICIAR);
            Controls.Add(BTNVALIDAR);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BTNVALIDAR;
        private Button BTNREINICIAR;
        private TextBox TXTNUMERO;
        private Button BTNGENERAR;
        private Label label3;
        private Label LBLPICAS;
        private Label LBLFIJAS;
        private Label NUMEROALBL;
    }
}