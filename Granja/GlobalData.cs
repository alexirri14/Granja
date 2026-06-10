using System;
using System.Collections.Generic;

namespace Granja
{
    // Clase para representar una Producción
    public class ProduccionItem
    {
        public string Galpon { get; set; }
        public DateTime Fecha { get; set; }
        public int Javas { get; set; }
        public int Huevos => Javas * GlobalData.HuevosPorJava;
    }

    // Clase para representar un Movimiento de Huevos
    public class MovimientoHuevo
    {
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public string Detalle { get; set; }
        public int Cantidad { get; set; }
    }

    // Clase para representar una Venta
    public class Venta
    {
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total => Cantidad * Precio;
    }

    // Clase para representar un Insumo
    public class Insumo
    {
        public string Nombre { get; set; }
        public double StockActual { get; set; }
        public double StockMinimo { get; set; }
        public string Unidad { get; set; } // KG, Litros, etc.
        public double KgPorSaco { get; set; } // Si es sacado
    }

    // Clase para representar un Movimiento de Insumo
    public class MovimientoInsumo
    {
        public DateTime Fecha { get; set; }
        public string Insumo { get; set; }
        public string Tipo { get; set; } // Entrada, Consumo, Perdida
        public double Cantidad { get; set; }
        public string Galpon { get; set; }
        public string Observaciones { get; set; }
    }

    // Clase para representar una Receta
    public class Receta
    {
        public string NombreGalpon { get; set; }
        public List<RecetaItem> Insumos { get; set; } = new List<RecetaItem>();
    }

    public class RecetaItem
    {
        public string Insumo { get; set; }
        public double Cantidad { get; set; }
    }

    // Clase para representar un Movimiento de Alimento
    public class MovimientoAlimento
    {
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; } // Entrada (Molino), Salida (Produccion), Perdida
        public double CantidadSacos { get; set; }
        public string Observaciones { get; set; }
    }

    // Clase principal para datos globales
    public static class GlobalData
    {
        // Ventas
        public static List<Venta> Ventas { get; set; } = new List<Venta>();

        // Huevos
        public static int StockHuevos { get; set; } = 8500;
        public static List<MovimientoHuevo> MovimientosHuevos { get; set; } = new List<MovimientoHuevo>();

        // Producción
        public static List<ProduccionItem> Producciones { get; set; } = new List<ProduccionItem>();

        // Insumos
        public static List<Insumo> Insumos { get; set; } = new List<Insumo>
        {
            new Insumo { Nombre = "Maíz", StockActual = 2500, StockMinimo = 500, Unidad = "KG", KgPorSaco = 50 },
            new Insumo { Nombre = "Torta de Soya", StockActual = 1200, StockMinimo = 300, Unidad = "KG", KgPorSaco = 50 },
            new Insumo { Nombre = "Soya Integral", StockActual = 800, StockMinimo = 200, Unidad = "KG", KgPorSaco = 50 },
            new Insumo { Nombre = "Afrechillo", StockActual = 600, StockMinimo = 150, Unidad = "KG", KgPorSaco = 50 },
            new Insumo { Nombre = "Sal Industrial", StockActual = 400, StockMinimo = 100, Unidad = "KG", KgPorSaco = 25 },
            new Insumo { Nombre = "Calcio", StockActual = 200, StockMinimo = 50, Unidad = "KG", KgPorSaco = 25 },
            new Insumo { Nombre = "Fósforo", StockActual = 150, StockMinimo = 30, Unidad = "KG", KgPorSaco = 25 },
            new Insumo { Nombre = "Premix Vitamínico", StockActual = 50, StockMinimo = 10, Unidad = "KG", KgPorSaco = 10 },
            new Insumo { Nombre = "Aceite Vegetal", StockActual = 100, StockMinimo = 20, Unidad = "Litros", KgPorSaco = 0 }
        };

        // Movimientos de Insumos
        public static List<MovimientoInsumo> MovimientosInsumos { get; set; } = new List<MovimientoInsumo>();

        // Recetas por Galpón
        public static List<Receta> Recetas { get; set; } = new List<Receta>
        {
            new Receta
            {
                NombreGalpon = "Galpón 4",
                Insumos = new List<RecetaItem>
                {
                    new RecetaItem { Insumo = "Maíz", Cantidad = 60 },
                    new RecetaItem { Insumo = "Torta de Soya", Cantidad = 25 },
                    new RecetaItem { Insumo = "Afrechillo", Cantidad = 10 },
                    new RecetaItem { Insumo = "Calcio", Cantidad = 2 },
                    new RecetaItem { Insumo = "Fósforo", Cantidad = 1.5 },
                    new RecetaItem { Insumo = "Premix Vitamínico", Cantidad = 1 },
                    new RecetaItem { Insumo = "Aceite Vegetal", Cantidad = 0.5 }
                }
            },
            new Receta
            {
                NombreGalpon = "Galpón 6-8-7",
                Insumos = new List<RecetaItem>
                {
                    new RecetaItem { Insumo = "Maíz", Cantidad = 62 },
                    new RecetaItem { Insumo = "Torta de Soya", Cantidad = 23 },
                    new RecetaItem { Insumo = "Afrechillo", Cantidad = 11 },
                    new RecetaItem { Insumo = "Calcio", Cantidad = 2.2 },
                    new RecetaItem { Insumo = "Fósforo", Cantidad = 1.3 },
                    new RecetaItem { Insumo = "Premix Vitamínico", Cantidad = 1 },
                    new RecetaItem { Insumo = "Aceite Vegetal", Cantidad = 0.5 }
                }
            },
            new Receta
            {
                NombreGalpon = "Galpón 3-5-8",
                Insumos = new List<RecetaItem>
                {
                    new RecetaItem { Insumo = "Maíz", Cantidad = 58 },
                    new RecetaItem { Insumo = "Torta de Soya", Cantidad = 27 },
                    new RecetaItem { Insumo = "Afrechillo", Cantidad = 10 },
                    new RecetaItem { Insumo = "Calcio", Cantidad = 2.5 },
                    new RecetaItem { Insumo = "Fósforo", Cantidad = 1.5 },
                    new RecetaItem { Insumo = "Premix Vitamínico", Cantidad = 1 },
                    new RecetaItem { Insumo = "Aceite Vegetal", Cantidad = 0.5 }
                }
            }
        };

        // Alimento (Stock en Sacos y Movimientos)
        public static double StockAlimentoSacos { get; set; } = 300;
        public static List<MovimientoAlimento> MovimientosAlimento { get; set; } = new List<MovimientoAlimento>();

        // Constantes
        public const int HuevosPorJava = 360;
        public const double KgAlimentoPorJava = 0.25; // Ejemplo: 0.25 kg de alimento por java
    }
}
