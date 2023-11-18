<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Remis_Access_2000DataSet1 = New WindowsApplication1.Remis_Access_2000DataSet()
        Me.ChoferesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChoferesTableAdapter = New WindowsApplication1.Remis_Access_2000DataSetTableAdapters.ChoferesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Remis_Access_2000DataSetTableAdapters.TableAdapterManager()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New WindowsApplication1.Remis_Access_2000DataSetTableAdapters.ClientesTableAdapter()
        Me.ColoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColoresTableAdapter = New WindowsApplication1.Remis_Access_2000DataSetTableAdapters.ColoresTableAdapter()
        Me.ViajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViajesTableAdapter = New WindowsApplication1.Remis_Access_2000DataSetTableAdapters.ViajesTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.Remis_Access_2000DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChoferesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Remis_Access_2000DataSet1
        '
        Me.Remis_Access_2000DataSet1.DataSetName = "Remis_Access_2000DataSet"
        Me.Remis_Access_2000DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChoferesBindingSource
        '
        Me.ChoferesBindingSource.DataMember = "Choferes"
        Me.ChoferesBindingSource.DataSource = Me.Remis_Access_2000DataSet1
        '
        'ChoferesTableAdapter
        '
        Me.ChoferesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChoferesTableAdapter = Me.ChoferesTableAdapter
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.ColoresTableAdapter = Me.ColoresTableAdapter
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.ModelosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Remis_Access_2000DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ViajesTableAdapter = Me.ViajesTableAdapter
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.Remis_Access_2000DataSet1
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ColoresBindingSource
        '
        Me.ColoresBindingSource.DataMember = "Colores"
        Me.ColoresBindingSource.DataSource = Me.Remis_Access_2000DataSet1
        '
        'ColoresTableAdapter
        '
        Me.ColoresTableAdapter.ClearBeforeFill = True
        '
        'ViajesBindingSource
        '
        Me.ViajesBindingSource.DataMember = "Viajes"
        Me.ViajesBindingSource.DataSource = Me.Remis_Access_2000DataSet1
        '
        'ViajesTableAdapter
        '
        Me.ViajesTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(24, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Choferes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(435, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 54)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Colores"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(228, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 54)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Clientes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(24, 84)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(167, 54)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Marcas"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(228, 84)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(167, 54)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Modelos"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(435, 84)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(167, 54)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Viajes"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 161)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.Remis_Access_2000DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChoferesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Remis_Access_2000DataSet1 As WindowsApplication1.Remis_Access_2000DataSet
    Friend WithEvents ChoferesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChoferesTableAdapter As WindowsApplication1.Remis_Access_2000DataSetTableAdapters.ChoferesTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Remis_Access_2000DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientesTableAdapter As WindowsApplication1.Remis_Access_2000DataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ColoresTableAdapter As WindowsApplication1.Remis_Access_2000DataSetTableAdapters.ColoresTableAdapter
    Friend WithEvents ColoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViajesTableAdapter As WindowsApplication1.Remis_Access_2000DataSetTableAdapters.ViajesTableAdapter
    Friend WithEvents ViajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
