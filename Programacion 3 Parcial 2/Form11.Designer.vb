<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Me.RemisAccess2000DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChoferesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChoferesTableAdapter = New WindowsApplication1.Remis_Access_2000DataSetTableAdapters.ChoferesTableAdapter()
        Me.NroChoferDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomicilioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Remis_Access_2000DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemisAccess2000DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChoferesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroChoferDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DomicilioDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.PatenteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ChoferesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(745, 417)
        Me.DataGridView1.TabIndex = 0
        '
        'Remis_Access_2000DataSet
        '
        Me.Remis_Access_2000DataSet.DataSetName = "Remis_Access_2000DataSet"
        Me.Remis_Access_2000DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RemisAccess2000DataSetBindingSource
        '
        Me.RemisAccess2000DataSetBindingSource.DataSource = Me.Remis_Access_2000DataSet
        Me.RemisAccess2000DataSetBindingSource.Position = 0
        '
        'ChoferesBindingSource
        '
        Me.ChoferesBindingSource.DataMember = "Choferes"
        Me.ChoferesBindingSource.DataSource = Me.Remis_Access_2000DataSet
        '
        'ChoferesTableAdapter
        '
        Me.ChoferesTableAdapter.ClearBeforeFill = True
        '
        'NroChoferDataGridViewTextBoxColumn
        '
        Me.NroChoferDataGridViewTextBoxColumn.DataPropertyName = "Nro_Chofer"
        Me.NroChoferDataGridViewTextBoxColumn.HeaderText = "Nro_Chofer"
        Me.NroChoferDataGridViewTextBoxColumn.Name = "NroChoferDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'DomicilioDataGridViewTextBoxColumn
        '
        Me.DomicilioDataGridViewTextBoxColumn.DataPropertyName = "Domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.Name = "DomicilioDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        '
        'PatenteDataGridViewTextBoxColumn
        '
        Me.PatenteDataGridViewTextBoxColumn.DataPropertyName = "Patente"
        Me.PatenteDataGridViewTextBoxColumn.HeaderText = "Patente"
        Me.PatenteDataGridViewTextBoxColumn.Name = "PatenteDataGridViewTextBoxColumn"
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 441)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form11"
        Me.Text = "Form11"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Remis_Access_2000DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemisAccess2000DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChoferesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RemisAccess2000DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Remis_Access_2000DataSet As WindowsApplication1.Remis_Access_2000DataSet
    Friend WithEvents ChoferesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChoferesTableAdapter As WindowsApplication1.Remis_Access_2000DataSetTableAdapters.ChoferesTableAdapter
    Friend WithEvents NroChoferDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomicilioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
