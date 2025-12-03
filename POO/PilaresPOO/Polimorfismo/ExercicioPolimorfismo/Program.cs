using ExercicioPolimorfismo;

PagamentoPix compraPix = new PagamentoPix();
compraPix.ValorCompra = 15000;
float valorPagar = compraPix.CalcularTotal();
Console.WriteLine($"Pagamento do celular");
Console.WriteLine($"Preco: {compraPix.ValorCompra}");
Console.WriteLine($"Pagamento com desconto {valorPagar}");



PagamentoCartao compraCartao = new PagamentoCartao();
compraCartao.ValorCompra = 50;
Console.WriteLine($"Produto: Caneca");
Console.WriteLine($"Preco: {compraCartao.ValorCompra}");
Console.WriteLine($"Forma de pagamento : cartao");
Console.WriteLine($"Pagamento com acrescimo {compraCartao.CalcularTotal()}");



