<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.RemisAccess2000DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Remis_Access_2000DataSet = New WindowsApplication1.Remis_Access_2000DataSet()
        Me.ViajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViajesTableAdapter = New WindowsApplication1.Remis_Access_2000DataSetTableAdapters.ViajesTableAdapter()
        Me.ChoferesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChoferesTableAdapter = New WindowsApplication1.Remis_Access_2000DataSetTableAdapters.ChoferesTableAdapter()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.RemisAccess2000DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Remis_Access_2000DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChoferesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RemisAccess2000DataSetBindingSource
        '
        Me.RemisAccess2000DataSetBindingSource.DataSource = Me.Remis_Access_2000DataSet
        Me.RemisAccess2000DataSetBindingSource.Position = 0
        '
        'Remis_Access_2000DataSet
        '
        Me.Remis_Access_2000DataSet.DataSetName = "Remis_Access_2000DataSet"
        Me.Remis_Access_2000DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViajesBindingSource
        '
        Me.ViajesBindingSource.DataMember = "Viajes"
        Me.ViajesBindingSource.DataSource = Me.RemisAccess2000DataSetBindingSource
        '
        'ViajesTableAdapter
        '
        Me.ViajesTableAdapter.ClearBeforeFill = True
        '
        'ChoferesBindingSource
        '
        Me.ChoferesBindingSource.DataMember = "Choferes"
        Me.ChoferesBindingSource.DataSource = Me.RemisAccess2000DataSetBindingSource
        '
        'ChoferesTableAdapter
        '
        Me.ChoferesTableAdapter.ClearBeforeFill = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(439, 83)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(167, 54)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Viajes"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(232, 83)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(167, 54)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Modelos"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(28, 83)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(167, 54)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Marcas"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(232, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 54)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Clientes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(439, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 54)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Colores"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(28, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 54)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Choferes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 158)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.RemisAccess2000DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Remis_Access_2000DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChoferesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RemisAccess2000DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Remis_Access_2000DataSet As WindowsApplication1.Remis_Access_2000DataSet
    Friend WithEvents ViajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViajesTableAdapter As WindowsApplication1.Remis_Access_2000DataSetTableAdapters.ViajesTableAdapter
    Friend WithEvents ChoferesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChoferesTableAdapter As WindowsApplication1.Remis_Access_2000DataSetTableAdapters.ChoferesTableAdapter
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
