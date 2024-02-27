Imports System

Module Program
    Sub Main(args As String())
        Menu(10, 5)
        Menu(30, 8)
    End Sub

    Sub Menu(left As Integer, top As Integer)
        Console.SetCursorPosition(left, top)
        Console.WriteLine("┌──────────────┐")
        Console.SetCursorPosition(left, top + 1)
        Console.WriteLine("│     MENU     │")
        Console.SetCursorPosition(left, top + 2)
        Console.WriteLine("├──────────────┤")
        Console.SetCursorPosition(left, top + 3)
        Console.WriteLine("│    Item 1    │")
        Console.SetCursorPosition(left, top + 4)
        Console.WriteLine("│    Item 2    │")
        Console.SetCursorPosition(left, top + 5)
        Console.WriteLine("└──────────────┘")
    End Sub
End Module
