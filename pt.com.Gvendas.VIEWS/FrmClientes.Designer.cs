namespace C__GestaoVendas.pt.com.Gvendas.VIEWS
{
    partial class FrmClientes
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            txtPais = new TextBox();
            label11 = new Label();
            txtFreguesia = new TextBox();
            label12 = new Label();
            txtCidade = new TextBox();
            label13 = new Label();
            txtEndereco = new TextBox();
            label14 = new Label();
            txtTelem = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtPos = new TextBox();
            label5 = new Label();
            txtEmpresa = new TextBox();
            label4 = new Label();
            txtProfissao = new TextBox();
            label3 = new Label();
            txtNif = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            registerBtn = new Button();
            tabPage2 = new TabPage();
            panel3 = new Panel();
            filtrarBTn = new Button();
            label9 = new Label();
            txtSearchNome = new TextBox();
            atualizarBtn = new Button();
            dataGridView1 = new DataGridView();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nifDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            profissaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empresaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telemDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            moradaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            freguesiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteBindingSource = new BindingSource(components);
            label8 = new Label();
            errorProvider1 = new ErrorProvider(components);
            clienteBindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 591);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1109, 591);
            tabControl1.SizeMode = TabSizeMode.FillToRight;
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.AccessibleName = "";
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1101, 563);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ficha Cliente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(txtPais);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtFreguesia);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtCidade);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(txtEndereco);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(txtTelem);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtPos);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtEmpresa);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtProfissao);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtNif);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtNome);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(registerBtn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1095, 557);
            panel2.TabIndex = 2;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(654, 87);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(259, 23);
            txtPais.TabIndex = 66;
            txtPais.Validating += txtPais_Validating;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(654, 276);
            label11.Name = "label11";
            label11.Size = new Size(47, 15);
            label11.TabIndex = 65;
            label11.Text = "Cidade";
            // 
            // txtFreguesia
            // 
            txtFreguesia.Location = new Point(654, 359);
            txtFreguesia.Name = "txtFreguesia";
            txtFreguesia.Size = new Size(259, 23);
            txtFreguesia.TabIndex = 64;
            txtFreguesia.Validating += txtFreguesia_Validating;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(654, 341);
            label12.Name = "label12";
            label12.Size = new Size(62, 15);
            label12.TabIndex = 63;
            label12.Text = "Freguesia";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(654, 294);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(259, 23);
            txtCidade.TabIndex = 62;
            txtCidade.Validating += txtCidade_Validating;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(654, 69);
            label13.Name = "label13";
            label13.Size = new Size(31, 15);
            label13.TabIndex = 61;
            label13.Text = "País";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(125, 359);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(353, 23);
            txtEndereco.TabIndex = 60;
            txtEndereco.Validating += txtEndereco_Validating;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.Location = new Point(125, 341);
            label14.Name = "label14";
            label14.Size = new Size(48, 15);
            label14.TabIndex = 59;
            label14.Text = "Morada";
            // 
            // txtTelem
            // 
            txtTelem.Location = new Point(654, 228);
            txtTelem.Name = "txtTelem";
            txtTelem.Size = new Size(259, 23);
            txtTelem.TabIndex = 58;
            txtTelem.Validating += txtTelem_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(654, 210);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 57;
            label7.Text = "Telemóvel";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(654, 155);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(259, 23);
            txtEmail.TabIndex = 56;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(654, 137);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 55;
            label6.Text = "Email";
            // 
            // txtPos
            // 
            txtPos.Location = new Point(125, 422);
            txtPos.Name = "txtPos";
            txtPos.Size = new Size(259, 23);
            txtPos.TabIndex = 54;
            txtPos.Validating += txtPos_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(125, 404);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 53;
            label5.Text = "Código-Postal";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(125, 294);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(353, 23);
            txtEmpresa.TabIndex = 52;
            txtEmpresa.Validating += txtEmpresa_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(125, 276);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 51;
            label4.Text = "Empresa";
            // 
            // txtProfissao
            // 
            txtProfissao.Location = new Point(125, 228);
            txtProfissao.Name = "txtProfissao";
            txtProfissao.Size = new Size(353, 23);
            txtProfissao.TabIndex = 50;
            txtProfissao.Validating += txtProfissao_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(125, 210);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 49;
            label3.Text = "Profissão";
            // 
            // txtNif
            // 
            txtNif.Location = new Point(125, 155);
            txtNif.Name = "txtNif";
            txtNif.Size = new Size(353, 23);
            txtNif.TabIndex = 48;
            txtNif.Validating += txtNif_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(125, 137);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 47;
            label2.Text = "NIF";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(125, 87);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(353, 23);
            txtNome.TabIndex = 46;
            txtNome.Validating += txtNome_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 69);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 45;
            label1.Text = "Nome";
            // 
            // registerBtn
            // 
            registerBtn.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerBtn.Location = new Point(745, 472);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(253, 28);
            registerBtn.TabIndex = 23;
            registerBtn.Text = "Registar";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1101, 563);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(filtrarBTn);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtSearchNome);
            panel3.Controls.Add(atualizarBtn);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(label8);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1095, 557);
            panel3.TabIndex = 3;
            // 
            // filtrarBTn
            // 
            filtrarBTn.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filtrarBTn.Location = new Point(886, 55);
            filtrarBTn.Name = "filtrarBTn";
            filtrarBTn.Size = new Size(115, 26);
            filtrarBTn.TabIndex = 47;
            filtrarBTn.Text = "Filtrar";
            filtrarBTn.UseVisualStyleBackColor = true;
            filtrarBTn.Click += filtrarBTn_Click;
            // 
            // label9
            // 
            label9.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(361, 57);
            label9.Name = "label9";
            label9.Size = new Size(164, 36);
            label9.TabIndex = 46;
            label9.Text = "Pesquisar por nome:";
            // 
            // txtSearchNome
            // 
            txtSearchNome.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtSearchNome.Location = new Point(531, 58);
            txtSearchNome.Name = "txtSearchNome";
            txtSearchNome.PlaceholderText = "Procurar por nome";
            txtSearchNome.Size = new Size(334, 21);
            txtSearchNome.TabIndex = 25;
            // 
            // atualizarBtn
            // 
            atualizarBtn.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            atualizarBtn.Location = new Point(748, 502);
            atualizarBtn.Name = "atualizarBtn";
            atualizarBtn.Size = new Size(253, 28);
            atualizarBtn.TabIndex = 24;
            atualizarBtn.Text = "Atualizar";
            atualizarBtn.UseVisualStyleBackColor = true;
            atualizarBtn.Click += atualizarBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nomeDataGridViewTextBoxColumn, nifDataGridViewTextBoxColumn, profissaoDataGridViewTextBoxColumn, empresaDataGridViewTextBoxColumn, cpDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telemDataGridViewTextBoxColumn, moradaDataGridViewTextBoxColumn, cidadeDataGridViewTextBoxColumn, freguesiaDataGridViewTextBoxColumn, paisDataGridViewTextBoxColumn });
            dataGridView1.DataSource = clienteBindingSource;
            dataGridView1.GridColor = SystemColors.GrayText;
            dataGridView1.Location = new Point(62, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(939, 360);
            dataGridView1.TabIndex = 2;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nifDataGridViewTextBoxColumn
            // 
            nifDataGridViewTextBoxColumn.DataPropertyName = "Nif";
            nifDataGridViewTextBoxColumn.HeaderText = "Nif";
            nifDataGridViewTextBoxColumn.Name = "nifDataGridViewTextBoxColumn";
            nifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profissaoDataGridViewTextBoxColumn
            // 
            profissaoDataGridViewTextBoxColumn.DataPropertyName = "Profissao";
            profissaoDataGridViewTextBoxColumn.HeaderText = "Profissao";
            profissaoDataGridViewTextBoxColumn.Name = "profissaoDataGridViewTextBoxColumn";
            profissaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            empresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpDataGridViewTextBoxColumn
            // 
            cpDataGridViewTextBoxColumn.DataPropertyName = "Pos";
            cpDataGridViewTextBoxColumn.HeaderText = "Pos";
            cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            cpDataGridViewTextBoxColumn.ReadOnly = true;
            cpDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telemDataGridViewTextBoxColumn
            // 
            telemDataGridViewTextBoxColumn.DataPropertyName = "Telem";
            telemDataGridViewTextBoxColumn.HeaderText = "Telem";
            telemDataGridViewTextBoxColumn.Name = "telemDataGridViewTextBoxColumn";
            telemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moradaDataGridViewTextBoxColumn
            // 
            moradaDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            moradaDataGridViewTextBoxColumn.HeaderText = "Endereco";
            moradaDataGridViewTextBoxColumn.Name = "moradaDataGridViewTextBoxColumn";
            moradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // freguesiaDataGridViewTextBoxColumn
            // 
            freguesiaDataGridViewTextBoxColumn.DataPropertyName = "Freguesia";
            freguesiaDataGridViewTextBoxColumn.HeaderText = "Freguesia";
            freguesiaDataGridViewTextBoxColumn.Name = "freguesiaDataGridViewTextBoxColumn";
            freguesiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            paisDataGridViewTextBoxColumn.DataPropertyName = "Pais";
            paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            paisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(MODEL.Cliente);
            // 
            // label8
            // 
            label8.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(62, 55);
            label8.Name = "label8";
            label8.Size = new Size(162, 23);
            label8.TabIndex = 0;
            label8.Text = "Base de dados";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkRate = 100;
            errorProvider1.ContainerControl = this;
            // 
            // clienteBindingSource1
            // 
            clienteBindingSource1.DataSource = typeof(MODEL.Cliente);
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1109, 591);
            Controls.Add(panel1);
            Name = "FrmClientes";
            Text = "FrmClientes";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel2;
        private TabPage tabPage2;
        private Panel panel3;
        private Button registerBtn;
        private DataGridView dataGridView1;
        private Label label8;
        private BindingSource clienteBindingSource;
        private Button atualizarBtn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nifDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profissaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn freguesiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private ErrorProvider errorProvider1;
        private BindingSource clienteBindingSource1;
        private TextBox txtPais;
        private Label label11;
        private TextBox txtFreguesia;
        private Label label12;
        private TextBox txtCidade;
        private Label label13;
        private TextBox txtEndereco;
        private Label label14;
        private TextBox txtTelem;
        private Label label7;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtPos;
        private Label label5;
        private TextBox txtEmpresa;
        private Label label4;
        private TextBox txtProfissao;
        private Label label3;
        private TextBox txtNif;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private Button filtrarBTn;
        private Label label9;
        private TextBox txtSearchNome;
    }
}