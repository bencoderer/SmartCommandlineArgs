Module Program
    Sub Main(args As String())
        Dim tester = New SmartArgsPackage.Tester.SmartArgsTester() With {.WaitForKeyPressOnCompletion = False}

        tester.Run(args)
    End Sub
End Module
