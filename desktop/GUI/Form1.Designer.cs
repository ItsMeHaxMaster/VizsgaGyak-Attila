namespace GUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvAutok = new DataGridView();
            lblAutokListaja = new Label();
            lbAutok = new ListBox();
            lblEv = new Label();
            tbEv = new TextBox();
            btnBetolt = new Button();
            btnBezar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAutok).BeginInit();
            SuspendLayout();
            // 
            // dgvAutok
            // 
            dgvAutok.AllowUserToAddRows = false;
            dgvAutok.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAutok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAutok.ColumnHeadersHeight = 40;
            dgvAutok.Location = new Point(12, 12);
            dgvAutok.Name = "dgvAutok";
            dgvAutok.ReadOnly = true;
            dgvAutok.RowHeadersWidth = 72;
            dgvAutok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAutok.Size = new Size(1037, 469);
            dgvAutok.TabIndex = 0;
            // 
            // lblAutokListaja
            // 
            lblAutokListaja.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAutokListaja.Location = new Point(12, 509);
            lblAutokListaja.Name = "lblAutokListaja";
            lblAutokListaja.Size = new Size(150, 32);
            lblAutokListaja.TabIndex = 1;
            lblAutokListaja.Text = "Autók listája:";
            // 
            // lbAutok
            // 
            lbAutok.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbAutok.Location = new Point(12, 546);
            lbAutok.Name = "lbAutok";
            lbAutok.Size = new Size(300, 184);
            lbAutok.TabIndex = 2;
            // 
            // lblEv
            // 
            lblEv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblEv.Location = new Point(330, 509);
            lblEv.Name = "lblEv";
            lblEv.Size = new Size(41, 32);
            lblEv.TabIndex = 3;
            lblEv.Text = "Év:";
            // 
            // tbEv
            // 
            tbEv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tbEv.Location = new Point(377, 506);
            tbEv.Name = "tbEv";
            tbEv.Size = new Size(100, 35);
            tbEv.TabIndex = 4;
            tbEv.TextChanged += tbEv_TextChanged;
            // 
            // btnBetolt
            // 
            btnBetolt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBetolt.Location = new Point(852, 701);
            btnBetolt.Name = "btnBetolt";
            btnBetolt.Size = new Size(90, 47);
            btnBetolt.TabIndex = 5;
            btnBetolt.Text = "Betölt";
            btnBetolt.Click += btnBetolt_Click;
            // 
            // btnBezar
            // 
            btnBezar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBezar.Location = new Point(959, 701);
            btnBezar.Name = "btnBezar";
            btnBezar.Size = new Size(90, 47);
            btnBezar.TabIndex = 6;
            btnBezar.Text = "Bezár";
            btnBezar.Click += btnBezar_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(1061, 764);
            Controls.Add(dgvAutok);
            Controls.Add(lblAutokListaja);
            Controls.Add(lbAutok);
            Controls.Add(lblEv);
            Controls.Add(tbEv);
            Controls.Add(btnBetolt);
            Controls.Add(btnBezar);
            MinimumSize = new Size(700, 450);
            Name = "Form1";
            Text = "Autók";
            ((System.ComponentModel.ISupportInitialize)dgvAutok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAutok;
        private Label lblAutokListaja;
        private ListBox lbAutok;
        private Label lblEv;
        private TextBox tbEv;
        private Button btnBetolt;
        private Button btnBezar;
    }
}
