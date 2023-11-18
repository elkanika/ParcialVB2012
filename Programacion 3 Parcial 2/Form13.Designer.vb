<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Remis_Access_2000DataSet = New WindowsApplication1.Remis_Access_2000DataSet()
        Me.ColoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColoresTableAdapter = New WindowsApplication1.Remis_Access_2000DataSetTableAdapters.ColoresTableAdapter()
        Me.NroColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Remis_Access_2000DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroColorDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ColoresBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(259, 361)
        Me.DataGridView1.TabIndex = 0
        '
        'Remis_Access_2000DataSet
        '
        Me.Remis_Access_2000DataSet.DataSetName = "Remis_Access_2000DataSet"
        Me.Remis_Access_2000DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ColoresBindingSource
        '
        Me.ColoresBindingSource.DataMember = "Colores"
        Me.ColoresBindingSource.DataSource = Me.Remis_Access_2000DataSet
        '
        'ColoresTableAdapter
        '
        Me.ColoresTableAdapter.ClearBeforeFill = True
        '
        'NroColorDataGridViewTextBoxColumn
        '
        Me.NroColorDataGridViewTextBoxColumn.DataPropertyName = "Nro_Color"
        Me.NroColorDataGridViewTextBoxColumn.HeaderText = "Nro_Color"
        Me.NroColorDataGridViewTextBoxColumn.Name = "NroColorDataGridViewTextBoxColumn"
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        '
        'Form13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 385)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form13"
        Me.Text = "Form13"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Remis_Access_2000DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Remis_Access_2000DataSet As WindowsApplication1.Remis_Access_2000DataSet
    Friend WithEvents ColoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ColoresTableAdapter As WindowsApplication1.Remis_Access_2000DataSetTableAdapters.ColoresTableAdapter
    Friend WithEvents NroColorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
