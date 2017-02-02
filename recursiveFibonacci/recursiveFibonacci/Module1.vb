Module Module1

    'Program to find the nth fibonacci number
    'Series starts with 0 and 1
    'Next term found by adding previous two term
    'Recursive calls made by finding (n-1)th and (n-2)th fibonacci number

    Function fib(ByVal n As Integer) As Integer

        If n = 0 Then
            Return 0
        End If

        If n = 1 Then
            Return 1
        End If

        Return fib(n - 2) + fib(n - 1)
    End Function

    Sub Main()

        Console.WriteLine(fib(10))

    End Sub

End Module
