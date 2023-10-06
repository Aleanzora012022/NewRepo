Module Module1

    Sub Main()

        Console.WriteLine("Bienvenido/a")

        While True
            Console.Write("Ingrese el precio del artículo: ")
            Dim precioArticulo As Decimal
            Dim dineroEntregado As Decimal

            Dim input As String = Console.ReadLine()
            If Not Decimal.TryParse(input, precioArticulo) Then
                Console.WriteLine("Error de entrada, favor de ingresar un número válido")
                Continue While
            End If

            If precioArticulo < 0 Then
                Exit While
            End If

            Console.Write("Ingresar la cantidad de dinero dada por el cliente: ")
            input = Console.ReadLine()
            If Not Decimal.TryParse(input, dineroEntregado) Then
                Console.WriteLine("Error de entrada, favor de ingresar un número válido.")
                Continue While
            End If

            If dineroEntregado > precioArticulo Then
                Dim cambio As Decimal = dineroEntregado - precioArticulo
                Console.WriteLine("Cambio a entregar: $" & cambio.ToString("0.00"))
                Console.ReadLine()
            ElseIf dineroEntregado = precioArticulo Then
                Console.WriteLine("Entrega del producto completada")
                Console.WriteLine("Gracias por su compra")
                Console.WriteLine("---------------------------------------------")
                Console.WriteLine("Laboratorio 2 realizado por Monica Alejandra Anzora Velasquez y Daniela Beatriz Rivas Hernandez")
                Console.ReadLine()
            Else
                Console.WriteLine("Debe pagar $" & (precioArticulo - dineroEntregado).ToString("0.00") & " más")
                Console.WriteLine("No posee suficiente dinero, vuelva pronto por su producto")
                Console.WriteLine("---------------------------------------------")
                Console.WriteLine("Laboratorio 2 realizado por Monica Alejandra Anzora Velasquez y Daniela Beatriz Rivas Hernandez")
                Console.ReadLine()
            End If
        End While

    End Sub

End Module
