﻿Public Class parts

    Private Sub Auto_PartsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Auto_PartsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Auto_PartsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DatabaseDataSet.Auto_Parts". При необходимости она может быть перемещена или удалена.
        Me.Auto_PartsTableAdapter.Fill(Me.DatabaseDataSet.Auto_Parts)

    End Sub
End Class