namespace UI.Componentes;

partial class Tabela
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle headerCellStlyleDefault = new DataGridViewCellStyle();
        DataGridViewCellStyle cellStyleDefault = new DataGridViewCellStyle();
        ((System.ComponentModel.ISupportInitialize)this).BeginInit();
        SuspendLayout();
        // 
        // TabelaBase
        // 
        BackgroundColor = Color.FromArgb(31, 41, 55);
        BorderStyle = BorderStyle.None;
        CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

        headerCellStlyleDefault.Alignment = DataGridViewContentAlignment.MiddleLeft;
        headerCellStlyleDefault.BackColor = Color.FromArgb(31, 41, 55);
        headerCellStlyleDefault.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        headerCellStlyleDefault.ForeColor = SystemColors.Control;
        headerCellStlyleDefault.Padding = new Padding(2);
        headerCellStlyleDefault.SelectionBackColor = Color.FromArgb(55, 65, 81);
        headerCellStlyleDefault.SelectionForeColor = SystemColors.Control;
        headerCellStlyleDefault.WrapMode = DataGridViewTriState.True;

        /*
         
            It is a bug, although Microsoft would probably try to call it a feature. 
            The DataGridView header cells are supposed to inherit the current theme only if EnableHeadersVisualStyles is set to TRUE,
            and use the settings in ColumnHeaderDefaultCellStyles if it is false. But the DGV ignores EnableHeadersVisualStyles and 
           always inherits the font of the parent container it resides in.
         */
        EnableHeadersVisualStyles = false;



        ColumnHeadersDefaultCellStyle = headerCellStlyleDefault;
        ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        cellStyleDefault.Alignment = DataGridViewContentAlignment.MiddleLeft;
        cellStyleDefault.BackColor = Color.FromArgb(31, 41, 55);
        cellStyleDefault.Font = new Font("Segoe UI", 9F);
        cellStyleDefault.ForeColor = SystemColors.HighlightText;
        cellStyleDefault.SelectionBackColor = Color.Transparent;
        cellStyleDefault.SelectionForeColor = SystemColors.HighlightText;
        cellStyleDefault.WrapMode = DataGridViewTriState.False;
        DefaultCellStyle = cellStyleDefault;
        CellPainting += TabelaBase_CellPainting;
        ((System.ComponentModel.ISupportInitialize)this).EndInit();
        RowHeadersVisible = false;

        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        Dock = DockStyle.Fill;

        CellBorderStyle = DataGridViewCellBorderStyle.None;
        ResumeLayout();
    }

    #endregion
}
