
namespace Exercicio_PDV
{
    partial class Pn1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDesc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbProd = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCod = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gbVenda = new System.Windows.Forms.GroupBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lbTroco = new System.Windows.Forms.Label();
            this.lbRecebido = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.txtRecebido = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbProd.SuspendLayout();
            this.gbVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lbDesc);
            this.panel1.Location = new System.Drawing.Point(45, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 51);
            this.panel1.TabIndex = 0;
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDesc.Location = new System.Drawing.Point(121, 9);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(263, 32);
            this.lbDesc.TabIndex = 1;
            this.lbDesc.Text = "Descrição do Produto";
            this.lbDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(269, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(296, 296);
            this.dataGridView1.TabIndex = 1;
            // 
            // gbProd
            // 
            this.gbProd.Controls.Add(this.btnRemover);
            this.gbProd.Controls.Add(this.btnIncluir);
            this.gbProd.Controls.Add(this.label3);
            this.gbProd.Controls.Add(this.label2);
            this.gbProd.Controls.Add(this.lbCod);
            this.gbProd.Controls.Add(this.txtPreco);
            this.gbProd.Controls.Add(this.txtQuantidade);
            this.gbProd.Controls.Add(this.txtCodigo);
            this.gbProd.Location = new System.Drawing.Point(45, 126);
            this.gbProd.Name = "gbProd";
            this.gbProd.Size = new System.Drawing.Size(185, 228);
            this.gbProd.TabIndex = 2;
            this.gbProd.TabStop = false;
            this.gbProd.Text = "Produto";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(88, 191);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 7;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(7, 191);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Preço Unitário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade:";
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.Location = new System.Drawing.Point(7, 26);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(49, 15);
            this.lbCod.TabIndex = 3;
            this.lbCod.Text = "Código:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(6, 146);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(152, 23);
            this.txtPreco.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(6, 98);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(152, 23);
            this.txtQuantidade.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(6, 47);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(152, 23);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // gbVenda
            // 
            this.gbVenda.Controls.Add(this.btnFinalizar);
            this.gbVenda.Controls.Add(this.lbTroco);
            this.gbVenda.Controls.Add(this.lbRecebido);
            this.gbVenda.Controls.Add(this.txtTroco);
            this.gbVenda.Controls.Add(this.txtRecebido);
            this.gbVenda.Location = new System.Drawing.Point(45, 372);
            this.gbVenda.Name = "gbVenda";
            this.gbVenda.Size = new System.Drawing.Size(185, 113);
            this.gbVenda.TabIndex = 3;
            this.gbVenda.TabStop = false;
            this.gbVenda.Text = "Venda";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(10, 80);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(153, 23);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // lbTroco
            // 
            this.lbTroco.AutoSize = true;
            this.lbTroco.Location = new System.Drawing.Point(59, 54);
            this.lbTroco.Name = "lbTroco";
            this.lbTroco.Size = new System.Drawing.Size(39, 15);
            this.lbTroco.TabIndex = 3;
            this.lbTroco.Text = "Troco:";
            // 
            // lbRecebido
            // 
            this.lbRecebido.AutoSize = true;
            this.lbRecebido.Location = new System.Drawing.Point(10, 25);
            this.lbRecebido.Name = "lbRecebido";
            this.lbRecebido.Size = new System.Drawing.Size(88, 15);
            this.lbRecebido.TabIndex = 2;
            this.lbRecebido.Text = "Valor Recebido:";
            // 
            // txtTroco
            // 
            this.txtTroco.Location = new System.Drawing.Point(104, 51);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(59, 23);
            this.txtTroco.TabIndex = 1;
            // 
            // txtRecebido
            // 
            this.txtRecebido.Location = new System.Drawing.Point(104, 22);
            this.txtRecebido.Name = "txtRecebido";
            this.txtRecebido.Size = new System.Drawing.Size(59, 23);
            this.txtRecebido.TabIndex = 0;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(424, 456);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(35, 15);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(465, 452);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 5;
            // 
            // Pn1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 498);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.gbVenda);
            this.Controls.Add(this.gbProd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Pn1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbProd.ResumeLayout(false);
            this.gbProd.PerformLayout();
            this.gbVenda.ResumeLayout(false);
            this.gbVenda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbProd;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCod;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox gbVenda;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lbTroco;
        private System.Windows.Forms.Label lbRecebido;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.TextBox txtRecebido;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

