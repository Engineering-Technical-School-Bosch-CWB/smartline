namespace SmartLine.Services.ProductService;

public static class RegrasAderencia
{
    static readonly List<DateOnly> Feriados = [
        new(2025, 4, 21), // Tiradentes
        new(2025, 5, 1),  // Dia do Trabalho
        new(2025, 12, 25) // Natal
    ];

    static readonly List<DateOnly> Compensacoes = [
        new(2025, 4, 12),
    ];

    public static Func<DateOnly, int> Celula1() => data =>
    {
        if (Feriados.Contains(data)) return 0;
        if (Compensacoes.Contains(data)) return 100;
        return data.DayOfWeek switch
        {
            DayOfWeek.Saturday => 85,
            _ => 100
        };
    };

    public static Func<DateOnly, int> Celula2() => data =>
    {
        if (Feriados.Contains(data)) return 0;
        if (Compensacoes.Contains(data)) return 100;
        return data.DayOfWeek switch
        {
            DayOfWeek.Saturday => 85,
            _ => 100
        };
    };

    public static Func<DateOnly, int> Celula3() => data =>
    {
        if (Feriados.Contains(data)) return 0;
        if (Compensacoes.Contains(data)) return 100;
        return data.DayOfWeek switch
        {
            DayOfWeek.Saturday => 85,
            _ => 100
        };
    };

    public static Func<DateOnly, int> Celula4() => data =>
    {
        if (Feriados.Contains(data)) return 0;
        if (Compensacoes.Contains(data)) return 100;
        return data.DayOfWeek switch
        {
            DayOfWeek.Saturday => 85,
            _ => 100
        };
    };

    public static Func<DateOnly, int> Celula5() => data =>
    {
        if (Feriados.Contains(data)) return 0;
        if (Compensacoes.Contains(data)) return 100;
        return data.DayOfWeek switch
        {
            DayOfWeek.Saturday => 85,
            _ => 100
        };
    };
}
