
namespace reajuste_de_folha_de_pagamento
{
    partial class ReajusteDeFolhaDePagamento
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPercentualReajuste = new System.Windows.Forms.Label();
            this.lblTotalSemReajuste = new System.Windows.Forms.Label();
            this.lblTotalSReajuste = new System.Windows.Forms.Label();
            this.lblTotalComReajuste = new System.Windows.Forms.Label();
            this.lblTotalCReajuste = new System.Windows.Forms.Label();
            this.lblPercentualR = new System.Windows.Forms.Label();
            this.dgvLeitura = new System.Windows.Forms.DataGridView();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btnSelecionarArquivo = new System.Windows.Forms.Button();
            this.ofdListaFuncionarios = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(29, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 97);
            this.panel1.TabIndex = 1;
            this.panel1.Tag = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.17127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.82873F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel1.Controls.Add(this.lblPercentualReajuste, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalSemReajuste, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalSReajuste, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalComReajuste, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalCReajuste, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPercentualR, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.75325F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.24675F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(613, 91);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblPercentualReajuste
            // 
            this.lblPercentualReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblPercentualReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualReajuste.Location = new System.Drawing.Point(422, 0);
            this.lblPercentualReajuste.Name = "lblPercentualReajuste";
            this.lblPercentualReajuste.Size = new System.Drawing.Size(188, 42);
            this.lblPercentualReajuste.TabIndex = 5;
            this.lblPercentualReajuste.Text = "Percentual reajuste";
            this.lblPercentualReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalSemReajuste
            // 
            this.lblTotalSemReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalSemReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSemReajuste.Location = new System.Drawing.Point(3, 0);
            this.lblTotalSemReajuste.Name = "lblTotalSemReajuste";
            this.lblTotalSemReajuste.Size = new System.Drawing.Size(200, 42);
            this.lblTotalSemReajuste.TabIndex = 3;
            this.lblTotalSemReajuste.Text = "Total sem reajuste";
            this.lblTotalSemReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalSReajuste
            // 
            this.lblTotalSReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSReajuste.Location = new System.Drawing.Point(3, 42);
            this.lblTotalSReajuste.Name = "lblTotalSReajuste";
            this.lblTotalSReajuste.Size = new System.Drawing.Size(171, 38);
            this.lblTotalSReajuste.TabIndex = 6;
            this.lblTotalSReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalComReajuste
            // 
            this.lblTotalComReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalComReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComReajuste.Location = new System.Drawing.Point(209, 0);
            this.lblTotalComReajuste.Name = "lblTotalComReajuste";
            this.lblTotalComReajuste.Size = new System.Drawing.Size(207, 42);
            this.lblTotalComReajuste.TabIndex = 4;
            this.lblTotalComReajuste.Text = "Total com reajuste";
            this.lblTotalComReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCReajuste
            // 
            this.lblTotalCReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCReajuste.Location = new System.Drawing.Point(209, 42);
            this.lblTotalCReajuste.Name = "lblTotalCReajuste";
            this.lblTotalCReajuste.Size = new System.Drawing.Size(176, 38);
            this.lblTotalCReajuste.TabIndex = 7;
            this.lblTotalCReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPercentualR
            // 
            this.lblPercentualR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualR.Location = new System.Drawing.Point(422, 42);
            this.lblPercentualR.Name = "lblPercentualR";
            this.lblPercentualR.Size = new System.Drawing.Size(184, 38);
            this.lblPercentualR.TabIndex = 8;
            this.lblPercentualR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLeitura
            // 
            this.dgvLeitura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitura.Location = new System.Drawing.Point(28, 146);
            this.dgvLeitura.Name = "dgvLeitura";
            this.dgvLeitura.RowHeadersWidth = 51;
            this.dgvLeitura.RowTemplate.Height = 24;
            this.dgvLeitura.Size = new System.Drawing.Size(620, 337);
            this.dgvLeitura.TabIndex = 3;
            // 
            // txtArquivo
            // 
            this.txtArquivo.Enabled = false;
            this.txtArquivo.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivo.Location = new System.Drawing.Point(28, 12);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(560, 25);
            this.txtArquivo.TabIndex = 6;
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(594, 12);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(44, 22);
            this.btnSelecionarArquivo.TabIndex = 7;
            this.btnSelecionarArquivo.Text = "...";
            this.btnSelecionarArquivo.UseCompatibleTextRendering = true;
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click_1);
            // 
            // ofdListaFuncionarios
            // 
            this.ofdListaFuncionarios.DefaultExt = "*.txt";
            this.ofdListaFuncionarios.FileName = "openFileDialog1";
            this.ofdListaFuncionarios.Filter = "Arquivos Textos|*.txt";
            this.ofdListaFuncionarios.Title = "Seleção do Arquvio com dados de funcionários ";
            // 
            // ReajusteDeFolhaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 495);
            this.Controls.Add(this.btnSelecionarArquivo);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.dgvLeitura);
            this.Controls.Add(this.panel1);
            this.Name = "ReajusteDeFolhaDePagamento";
            this.Text = "Leitura de Arquivo Para Reajuste De Salario";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvLeitura;
        private System.Windows.Forms.Label lblPercentualReajuste;
        private System.Windows.Forms.Label lblTotalSemReajuste;
        private System.Windows.Forms.Label lblTotalSReajuste;
        private System.Windows.Forms.Label lblTotalComReajuste;
        private System.Windows.Forms.Label lblTotalCReajuste;
        private System.Windows.Forms.Label lblPercentualR;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btnSelecionarArquivo;
        private System.Windows.Forms.OpenFileDialog ofdListaFuncionarios;
    }
}

