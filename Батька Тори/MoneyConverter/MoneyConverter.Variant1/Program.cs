using System;
using static System.Console;

namespace MoneyConverter.Variant1
{
    public enum MoneyType
    {
        rub, usd, eur, unknown
    }

    public class Converter
    {
        private readonly double _rub;
        private readonly double _usd;
        private readonly double _eur;

        public Converter(double rub, double usd, double eur)
        {
            _rub = rub;
            _usd = usd;
            _eur = eur;
        }

        public double FromGrivna(double money, MoneyType moneyType)
        {
            return moneyType switch
            {
                MoneyType.rub => _rub * money,
                MoneyType.usd => _usd * money,
                MoneyType.eur => _eur * money,
                _ => throw new Exception("Какая-то дристня")
            };
        }

        public double GrivnaTo(double money, MoneyType moneyType)
        {
            return moneyType switch
            {
                MoneyType.rub => money / _rub,
                MoneyType.usd => money / _usd,
                MoneyType.eur => money / _eur,
                _ => throw new Exception("Какая-то дристня")
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Write("Тип лавэ: ");
            if (!Enum.TryParse(ReadLine().ToLower(), out MoneyType moneyType))
            {
                throw new Exception("Быканул?");
            }
            Write("В гривну/Из гривны (0/1): ");
            bool? grivnaTo = null;

            switch (ReadLine())
            {
                case "0":
                    grivnaTo = true;
                    break;
                case "1":
                    grivnaTo = false;
                    break;
                default:
                    throw new Exception("Иди на хуй!");
            }

            Write("Сколько лавэ: ");
            if (!double.TryParse(ReadLine(), out double money))
            {
                throw new Exception("Ахуел?");
            }

            Converter converter = new Converter(2.7, 0.0034, 0.0031);

            if (!grivnaTo.Value)
            {
                WriteLine($"{money} {moneyType.ToString()} = {converter.GrivnaTo(money, moneyType)} гривн");
            }
            else
            {
                WriteLine($"{money} гривн = {converter.GrivnaTo(money, moneyType)} {moneyType.ToString()} ");
            }
        }
    }
}
