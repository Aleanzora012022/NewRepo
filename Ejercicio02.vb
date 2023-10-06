Module Module1

    Sub Main()
        Dim totalCompra As Decimal = 0

        Console.WriteLine("Bienvenido/a")

        While True
            Console.Write("Ingresar el monto de la compra: ")
            Dim montoCompra As Decimal

            Dim input As String = Console.ReadLine()
            If Not Decimal.TryParse(input, montoCompra) Then
                Console.WriteLine("Error de entrada, favor de ingresar un número valido")
                Continue While
            End If

            If montoCompra < 0 Then
                Exit While
            End If

            Dim descuento As Decimal = 0

            If montoCompra > 1000 Then
                descuento = montoCompra * 0.1
            ElseIf montoCompra > 500 Then
                descuento = montoCompra * 0.05
            End If

            Dim precioFinal As Decimal = montoCompra - descuento
            totalCompra += precioFinal

            Console.WriteLine("Subtotal: $" & montoCompra.ToString("0.00"))
            Console.WriteLine("EL descuento que se aplico: $" & descuento.ToString("0.00"))
            Console.WriteLine("El total a pagar: $" & precioFinal.ToString("0.00"))
            Console.WriteLine("Resumen de la compra:")
            Console.WriteLine("Total de la compra: $" & totalCompra.ToString("0.00"))
            Console.WriteLine("Gracias por su compra")

            Console.WriteLine("------------------------")
            Console.WriteLine("Laboratorio 2 realizado por Daniela Beatriz Rivas Hernandez y Monica Alejandra Anzora Velasquez")
            Console.ReadLine()

        End While

    End Sub

End Module
