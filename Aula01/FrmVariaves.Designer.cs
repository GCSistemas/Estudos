namespace Aula01
{
    partial class FrmVariaves
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
            this.btNumero = new System.Windows.Forms.Button();
            this.btTexto = new System.Windows.Forms.Button();
            this.btBoleean = new System.Windows.Forms.Button();
            this.btData = new System.Windows.Forms.Button();
            this.btParImpar = new System.Windows.Forms.Button();
            this.txtParImpar = new System.Windows.Forms.TextBox();
            this.txtBemVindo = new System.Windows.Forms.TextBox();
            this.btBemVindo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btMaior = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN03 = new System.Windows.Forms.TextBox();
            this.txtN02 = new System.Windows.Forms.TextBox();
            this.txtN01 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btForCliente = new System.Windows.Forms.Button();
            this.btFor = new System.Windows.Forms.Button();
            this.While = new System.Windows.Forms.Button();
            this.dgvListaCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btNumero
            // 
            this.btNumero.Location = new System.Drawing.Point(28, 21);
            this.btNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNumero.Name = "btNumero";
            this.btNumero.Size = new System.Drawing.Size(225, 58);
            this.btNumero.TabIndex = 0;
            this.btNumero.Text = "Número";
            this.btNumero.UseVisualStyleBackColor = true;
            this.btNumero.Click += new System.EventHandler(this.btNumero_Click);
            // 
            // btTexto
            // 
            this.btTexto.Location = new System.Drawing.Point(28, 85);
            this.btTexto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTexto.Name = "btTexto";
            this.btTexto.Size = new System.Drawing.Size(225, 58);
            this.btTexto.TabIndex = 1;
            this.btTexto.Text = "Texto";
            this.btTexto.UseVisualStyleBackColor = true;
            this.btTexto.Click += new System.EventHandler(this.btTexto_Click);
            // 
            // btBoleean
            // 
            this.btBoleean.Location = new System.Drawing.Point(28, 149);
            this.btBoleean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBoleean.Name = "btBoleean";
            this.btBoleean.Size = new System.Drawing.Size(225, 58);
            this.btBoleean.TabIndex = 2;
            this.btBoleean.Text = "Verdadeiro ou Falso";
            this.btBoleean.UseVisualStyleBackColor = true;
            this.btBoleean.Click += new System.EventHandler(this.btBoleean_Click);
            // 
            // btData
            // 
            this.btData.Location = new System.Drawing.Point(28, 213);
            this.btData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btData.Name = "btData";
            this.btData.Size = new System.Drawing.Size(225, 58);
            this.btData.TabIndex = 3;
            this.btData.Text = "Data";
            this.btData.UseVisualStyleBackColor = true;
            this.btData.Click += new System.EventHandler(this.btData_Click);
            // 
            // btParImpar
            // 
            this.btParImpar.Location = new System.Drawing.Point(28, 277);
            this.btParImpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btParImpar.Name = "btParImpar";
            this.btParImpar.Size = new System.Drawing.Size(225, 58);
            this.btParImpar.TabIndex = 4;
            this.btParImpar.Text = "Par ou Impar";
            this.btParImpar.UseVisualStyleBackColor = true;
            this.btParImpar.Click += new System.EventHandler(this.btParImpar_Click);
            // 
            // txtParImpar
            // 
            this.txtParImpar.Location = new System.Drawing.Point(28, 342);
            this.txtParImpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParImpar.Name = "txtParImpar";
            this.txtParImpar.Size = new System.Drawing.Size(225, 22);
            this.txtParImpar.TabIndex = 5;
            this.txtParImpar.Text = "1";
            this.txtParImpar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBemVindo
            // 
            this.txtBemVindo.Location = new System.Drawing.Point(28, 437);
            this.txtBemVindo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBemVindo.Name = "txtBemVindo";
            this.txtBemVindo.Size = new System.Drawing.Size(225, 22);
            this.txtBemVindo.TabIndex = 7;
            this.txtBemVindo.Text = "12";
            this.txtBemVindo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btBemVindo
            // 
            this.btBemVindo.Location = new System.Drawing.Point(28, 372);
            this.btBemVindo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBemVindo.Name = "btBemVindo";
            this.btBemVindo.Size = new System.Drawing.Size(225, 58);
            this.btBemVindo.TabIndex = 6;
            this.btBemVindo.Text = "Bem Vindo";
            this.btBemVindo.UseVisualStyleBackColor = true;
            this.btBemVindo.Click += new System.EventHandler(this.btBemVindo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btMaior);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtN03);
            this.groupBox1.Controls.Add(this.txtN02);
            this.groupBox1.Controls.Add(this.txtN01);
            this.groupBox1.Location = new System.Drawing.Point(260, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(313, 148);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maior Número";
            // 
            // btMaior
            // 
            this.btMaior.Location = new System.Drawing.Point(11, 73);
            this.btMaior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btMaior.Name = "btMaior";
            this.btMaior.Size = new System.Drawing.Size(285, 58);
            this.btMaior.TabIndex = 9;
            this.btMaior.Text = "Maior";
            this.btMaior.UseVisualStyleBackColor = true;
            this.btMaior.Click += new System.EventHandler(this.btMaior_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nº 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nº 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nº 1";
            // 
            // txtN03
            // 
            this.txtN03.Location = new System.Drawing.Point(215, 43);
            this.txtN03.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtN03.Name = "txtN03";
            this.txtN03.Size = new System.Drawing.Size(80, 22);
            this.txtN03.TabIndex = 8;
            this.txtN03.Text = "1";
            this.txtN03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtN02
            // 
            this.txtN02.Location = new System.Drawing.Point(109, 43);
            this.txtN02.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtN02.Name = "txtN02";
            this.txtN02.Size = new System.Drawing.Size(80, 22);
            this.txtN02.TabIndex = 7;
            this.txtN02.Text = "1";
            this.txtN02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtN01
            // 
            this.txtN01.Location = new System.Drawing.Point(11, 43);
            this.txtN01.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtN01.Name = "txtN01";
            this.txtN01.Size = new System.Drawing.Size(80, 22);
            this.txtN01.TabIndex = 6;
            this.txtN01.Text = "1";
            this.txtN01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btForCliente);
            this.groupBox2.Controls.Add(this.btFor);
            this.groupBox2.Controls.Add(this.While);
            this.groupBox2.Location = new System.Drawing.Point(260, 169);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(313, 218);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btForCliente
            // 
            this.btForCliente.Location = new System.Drawing.Point(11, 144);
            this.btForCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btForCliente.Name = "btForCliente";
            this.btForCliente.Size = new System.Drawing.Size(285, 58);
            this.btForCliente.TabIndex = 12;
            this.btForCliente.Text = "For Cliente";
            this.btForCliente.UseVisualStyleBackColor = true;
            this.btForCliente.Click += new System.EventHandler(this.btForCliente_Click);
            // 
            // btFor
            // 
            this.btFor.Location = new System.Drawing.Point(11, 81);
            this.btFor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btFor.Name = "btFor";
            this.btFor.Size = new System.Drawing.Size(285, 58);
            this.btFor.TabIndex = 11;
            this.btFor.Text = "For";
            this.btFor.UseVisualStyleBackColor = true;
            this.btFor.Click += new System.EventHandler(this.btFor_Click);
            // 
            // While
            // 
            this.While.Location = new System.Drawing.Point(11, 18);
            this.While.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.While.Name = "While";
            this.While.Size = new System.Drawing.Size(285, 58);
            this.While.TabIndex = 10;
            this.While.Text = "While";
            this.While.UseVisualStyleBackColor = true;
            this.While.Click += new System.EventHandler(this.While_Click);
            // 
            // dgvListaCliente
            // 
            this.dgvListaCliente.AllowUserToAddRows = false;
            this.dgvListaCliente.AllowUserToDeleteRows = false;
            this.dgvListaCliente.AllowUserToResizeColumns = false;
            this.dgvListaCliente.AllowUserToResizeRows = false;
            this.dgvListaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaCliente.Location = new System.Drawing.Point(596, 21);
            this.dgvListaCliente.Name = "dgvListaCliente";
            this.dgvListaCliente.RowHeadersVisible = false;
            this.dgvListaCliente.RowHeadersWidth = 51;
            this.dgvListaCliente.RowTemplate.Height = 24;
            this.dgvListaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCliente.Size = new System.Drawing.Size(520, 464);
            this.dgvListaCliente.TabIndex = 10;
            // 
            // FrmVariaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 497);
            this.Controls.Add(this.dgvListaCliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBemVindo);
            this.Controls.Add(this.btBemVindo);
            this.Controls.Add(this.txtParImpar);
            this.Controls.Add(this.btParImpar);
            this.Controls.Add(this.btData);
            this.Controls.Add(this.btBoleean);
            this.Controls.Add(this.btTexto);
            this.Controls.Add(this.btNumero);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmVariaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVariaves";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNumero;
        private System.Windows.Forms.Button btTexto;
        private System.Windows.Forms.Button btBoleean;
        private System.Windows.Forms.Button btData;
        private System.Windows.Forms.Button btParImpar;
        private System.Windows.Forms.TextBox txtParImpar;
        private System.Windows.Forms.TextBox txtBemVindo;
        private System.Windows.Forms.Button btBemVindo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN03;
        private System.Windows.Forms.TextBox txtN02;
        private System.Windows.Forms.TextBox txtN01;
        private System.Windows.Forms.Button btMaior;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button While;
        private System.Windows.Forms.Button btFor;
        private System.Windows.Forms.Button btForCliente;
        private System.Windows.Forms.DataGridView dgvListaCliente;
    }
}