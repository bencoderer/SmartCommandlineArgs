open System

[<EntryPoint>]
let main argv =
    let tester = new SmartArgsPackage.Tester.SmartArgsTester(WaitForKeyPressOnCompletion = false)
    tester.Run(argv)

    0 // Return an integer exit code
