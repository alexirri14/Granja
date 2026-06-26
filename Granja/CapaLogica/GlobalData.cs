using System;
using System.Collections.Generic;
using System.Linq;

namespace Granja
{
    public class Galpon
    {
        public string Nombre { get; set; } = string.Empty;
        public string Estado { get; set; } = "Activo";
        public string Observaciones { get; set; } = string.Empty;
    }

    public class Insumo
    {
        public string Nombre { get; set; } = string.Empty;
        public string Unidad { get; set; } = "KG";
        public double StockDisponible { get; set; }
        public double StockMinimo { get; set; }
        public string Estado { get; set; } = "Activo";
        public string Observaciones { get; set; } = string.Empty;
    }

    public class DocumentoDetalle
    {
        public string Item { get; set; } = string.Empty;
        public double Cantidad { get; set; }
        public string Unidad { get; set; } = string.Empty;
    }

    public class FormulaDetalle
    {
        public string Insumo { get; set; } = string.Empty;
        public double Cantidad { get; set; }
        public string Unidad { get; set; } = string.Empty;
    }

    public class FormulaAlimento
    {
        public string Nombre { get; set; } = string.Empty;
        public string Estado { get; set; } = "Activo";
        public string Detalle { get; set; } = string.Empty;
        public List<FormulaDetalle> Insumos { get; set; } = new();
    }

    public class SolicitudAbastecimientoInsumo
    {
        public string Numero { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string Insumo { get; set; } = string.Empty;
        public double Cantidad { get; set; }
        public string Estado { get; set; } = "Pendiente";
        public string Formula { get; set; } = string.Empty;
        public string Galpon { get; set; } = string.Empty;
        public string OrdenProduccionNumero { get; set; } = string.Empty;
        public string Detalle { get; set; } = string.Empty;
    }

    public class NotaIngresoInsumo
    {
        public string Numero { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string Proveedor { get; set; } = string.Empty;
        public string Detalle { get; set; } = string.Empty;
        public List<DocumentoDetalle> Detalles { get; set; } = new();
    }

    public class OrdenProduccion
    {
        public string Numero { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string Formula { get; set; } = string.Empty;
        public double CantidadObjetivo { get; set; }
        public double CantidadProducida { get; set; }
        public string Estado { get; set; } = "Pendiente";
        public string Detalle { get; set; } = string.Empty;
    }

    public class OrdenSalidaInsumo
    {
        public string Numero { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string OrdenProduccionNumero { get; set; } = string.Empty;
        public string Destino { get; set; } = "Producción";
        public string Detalle { get; set; } = string.Empty;
        public List<DocumentoDetalle> Detalles { get; set; } = new();
    }

    public class ProduccionAlimento
    {
        public string Numero { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string OrdenProduccionNumero { get; set; } = string.Empty;
        public string OrdenSalidaInsumoNumero { get; set; } = string.Empty;
        public string Formula { get; set; } = string.Empty;
        public double CantidadProducida { get; set; }
        public string Detalle { get; set; } = string.Empty;
    }

    public class NotaIngresoAlimento
    {
        public string Numero { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string Formula { get; set; } = string.Empty;
        public string OrdenProduccionNumero { get; set; } = string.Empty;
        public string ProduccionNumero { get; set; } = string.Empty;
        public string Detalle { get; set; } = string.Empty;
        public List<DocumentoDetalle> Detalles { get; set; } = new();
    }

    public class StockAlimentoBalanceado
    {
        public string Formula { get; set; } = string.Empty;
        public double StockDisponible { get; set; }
    }

    public class SolicitudAlimentoGalpon
    {
        public string Numero { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string Galpon { get; set; } = string.Empty;
        public string Formula { get; set; } = string.Empty;
        public double Cantidad { get; set; }
        public string Estado { get; set; } = "Pendiente";
        public string OrdenProduccionGenerada { get; set; } = string.Empty;
        public string Detalle { get; set; } = string.Empty;
    }

    public class OrdenSalidaAlmacenAlimento
    {
        public string Numero { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string Formula { get; set; } = string.Empty;
        public string Destino { get; set; } = "Distribución";
        public string SolicitudNumero { get; set; } = string.Empty;
        public string Detalle { get; set; } = string.Empty;
        public List<DocumentoDetalle> Detalles { get; set; } = new();
    }

    public class OrdenIngresoDistribucion
    {
        public string Numero { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string Galpon { get; set; } = string.Empty;
        public string Formula { get; set; } = string.Empty;
        public string OrdenSalidaAlmacenNumero { get; set; } = string.Empty;
        public string SolicitudNumero { get; set; } = string.Empty;
        public string Detalle { get; set; } = string.Empty;
        public List<DocumentoDetalle> Detalles { get; set; } = new();
    }

    public class MovimientoInsumo
    {
        public string Documento { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string Insumo { get; set; } = string.Empty;
        public double Cantidad { get; set; }
        public string Unidad { get; set; } = string.Empty;
        public double StockResultante { get; set; }
        public string Referencia { get; set; } = string.Empty;
        public string Detalle { get; set; } = string.Empty;
    }

    public class MovimientoAlimento
    {
        public string Documento { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string Formula { get; set; } = string.Empty;
        public double Cantidad { get; set; }
        public double StockResultante { get; set; }
        public string Referencia { get; set; } = string.Empty;
        public string Galpon { get; set; } = string.Empty;
        public string Detalle { get; set; } = string.Empty;
    }

    public static class GlobalData
    {
        private const double CapacidadBaseFormulaSacos = 30.0;

        public static List<Galpon> Galpones { get; } = new();
        public static List<Insumo> Insumos { get; } = new();
        public static List<FormulaAlimento> Formulas { get; } = new();
        public static List<SolicitudAbastecimientoInsumo> SolicitudesAbastecimientoInsumos { get; } = new();
        public static List<NotaIngresoInsumo> NotasIngresoInsumos { get; } = new();
        public static List<OrdenProduccion> OrdenesProduccion { get; } = new();
        public static List<OrdenSalidaInsumo> OrdenesSalidaInsumos { get; } = new();
        public static List<ProduccionAlimento> ProduccionesAlimento { get; } = new();
        public static List<NotaIngresoAlimento> NotasIngresoAlimento { get; } = new();
        public static List<StockAlimentoBalanceado> StockAlimentos { get; } = new();
        public static List<SolicitudAlimentoGalpon> SolicitudesAlimentoGalpones { get; } = new();
        public static List<OrdenSalidaAlmacenAlimento> OrdenesSalidaAlmacen { get; } = new();
        public static List<OrdenIngresoDistribucion> OrdenesIngresoDistribucion { get; } = new();
        public static List<MovimientoInsumo> MovimientosInsumos { get; } = new();
        public static List<MovimientoAlimento> MovimientosAlimento { get; } = new();

        static GlobalData()
        {
            InicializarDatosDemo();
        }

        public static IEnumerable<Galpon> ObtenerGalpones(string estado = "Todos")
        {
            return estado == "Todos"
                ? Galpones.OrderBy(g => g.Nombre)
                : Galpones.Where(g => g.Estado == estado).OrderBy(g => g.Nombre);
        }

        public static IEnumerable<Insumo> ObtenerInsumosActivos()
        {
            return Insumos.Where(i => i.Estado == "Activo").OrderBy(i => i.Nombre);
        }

        public static bool ExisteInsumo(string nombre)
        {
            return Insumos.Any(i => i.Nombre.Equals(nombre.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public static IEnumerable<FormulaAlimento> ObtenerFormulasActivas()
        {
            return Formulas.Where(f => f.Estado == "Activo").OrderBy(f => f.Nombre);
        }

        public static IEnumerable<SolicitudAbastecimientoInsumo> ObtenerSolicitudesAbastecimientoPendientes()
        {
            return SolicitudesAbastecimientoInsumos
                .Where(s => s.Estado == "Pendiente")
                .OrderByDescending(s => s.Fecha)
                .ThenBy(s => s.Numero);
        }

        public static Galpon RegistrarGalpon(string nombre, string observaciones)
        {
            ValidarTexto(nombre, "nombre del galpón");

            if (Galpones.Any(g => g.Nombre.Equals(nombre.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("No se puede registrar un galpón duplicado.");
            }

            var galpon = new Galpon
            {
                Nombre = nombre.Trim(),
                Observaciones = observaciones.Trim()
            };

            Galpones.Add(galpon);
            return galpon;
        }

        public static void ModificarGalpon(string nombreActual, string nuevoNombre, string observaciones, string estado)
        {
            var galpon = Galpones.First(g => g.Nombre == nombreActual);
            ValidarTexto(nuevoNombre, "nombre del galpón");

            if (!nombreActual.Equals(nuevoNombre.Trim(), StringComparison.OrdinalIgnoreCase) &&
                Galpones.Any(g => g.Nombre.Equals(nuevoNombre.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("Ya existe un galpón con ese nombre.");
            }

            galpon.Nombre = nuevoNombre.Trim();
            galpon.Observaciones = observaciones.Trim();
            galpon.Estado = estado;
        }

        public static Insumo RegistrarInsumo(string nombre, string unidad, double stockMinimo, double stockInicial, string observaciones)
        {
            ValidarTexto(nombre, "nombre del insumo");
            ValidarTexto(unidad, "unidad");

            if (Insumos.Any(i => i.Nombre.Equals(nombre.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("No se puede registrar un insumo duplicado.");
            }

            var insumo = new Insumo
            {
                Nombre = nombre.Trim(),
                Unidad = unidad.Trim(),
                StockMinimo = stockMinimo,
                StockDisponible = stockInicial,
                Observaciones = observaciones.Trim()
            };

            Insumos.Add(insumo);
            return insumo;
        }

        public static Insumo RegistrarInsumoDesdeIngreso(string nombre, string unidad, double stockMinimo, string observaciones)
        {
            return RegistrarInsumo(nombre, unidad, stockMinimo, 0, observaciones);
        }

        public static void ModificarInsumo(string nombreActual, string nuevoNombre, string unidad, double stockMinimo, string observaciones, string estado)
        {
            var insumo = Insumos.First(i => i.Nombre == nombreActual);
            ValidarTexto(nuevoNombre, "nombre del insumo");
            ValidarTexto(unidad, "unidad");

            if (!nombreActual.Equals(nuevoNombre.Trim(), StringComparison.OrdinalIgnoreCase) &&
                Insumos.Any(i => i.Nombre.Equals(nuevoNombre.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("Ya existe un insumo con ese nombre.");
            }

            insumo.Nombre = nuevoNombre.Trim();
            insumo.Unidad = unidad.Trim();
            insumo.StockMinimo = stockMinimo;
            insumo.Observaciones = observaciones.Trim();
            insumo.Estado = estado;

            foreach (var item in MovimientosInsumos.Where(m => m.Insumo == nombreActual))
            {
                item.Insumo = insumo.Nombre;
                item.Unidad = insumo.Unidad;
            }

            foreach (var solicitud in SolicitudesAbastecimientoInsumos.Where(s => s.Insumo == nombreActual))
            {
                solicitud.Insumo = insumo.Nombre;
            }

            foreach (var nota in NotasIngresoInsumos)
            {
                foreach (var detalle in nota.Detalles.Where(d => d.Item == nombreActual))
                {
                    detalle.Item = insumo.Nombre;
                    detalle.Unidad = insumo.Unidad;
                }
            }

            foreach (var formula in Formulas)
            {
                foreach (var detalle in formula.Insumos.Where(d => d.Insumo == nombreActual))
                {
                    detalle.Insumo = insumo.Nombre;
                    detalle.Unidad = insumo.Unidad;
                }
            }
        }

        public static SolicitudAbastecimientoInsumo RegistrarSolicitudAbastecimiento(DateTime fecha, string insumo, double cantidad, string detalle)
        {
            var insumoObj = Insumos.First(i => i.Nombre == insumo && i.Estado == "Activo");
            ValidarCantidad(cantidad, "La cantidad solicitada debe ser mayor a cero.");

            return RegistrarSolicitudAbastecimientoInterna(
                fecha,
                insumoObj.Nombre,
                cantidad,
                detalle.Trim(),
                string.Empty,
                string.Empty,
                string.Empty);
        }

        public static NotaIngresoInsumo RegistrarNotaIngresoInsumo(DateTime fecha, string proveedor, string detalle, List<DocumentoDetalle> detalles, string solicitudNumero = "")
        {
            ValidarTexto(proveedor, "proveedor");
            ValidarDetalleDocumento(detalles, "La nota de ingreso debe tener al menos un insumo.");

            var nota = new NotaIngresoInsumo
            {
                Numero = GenerarCorrelativo("NII", NotasIngresoInsumos.Count + 1),
                Fecha = fecha,
                Proveedor = proveedor.Trim(),
                Detalle = detalle.Trim(),
                Detalles = ClonarDetalles(detalles)
            };

            foreach (var item in nota.Detalles)
            {
                var insumo = Insumos.First(i => i.Nombre == item.Item && i.Estado == "Activo");
                insumo.StockDisponible += item.Cantidad;
                RegistrarMovimientoInsumo(nota.Numero, fecha, "Ingreso", insumo.Nombre, item.Cantidad, proveedor, detalle);
            }

            if (!string.IsNullOrWhiteSpace(solicitudNumero))
            {
                var solicitud = SolicitudesAbastecimientoInsumos.FirstOrDefault(s => s.Numero == solicitudNumero);
                if (solicitud != null)
                {
                    solicitud.Estado = "Atendida";
                }
            }

            NotasIngresoInsumos.Add(nota);
            return nota;
        }

        public static FormulaAlimento RegistrarFormula(string nombre, string detalle, List<FormulaDetalle> insumos)
        {
            ValidarTexto(nombre, "nombre de la fórmula");
            ValidarDetalleFormula(insumos);

            if (Formulas.Any(f => f.Nombre.Equals(nombre.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("No se puede registrar una fórmula duplicada.");
            }

            var formula = new FormulaAlimento
            {
                Nombre = nombre.Trim(),
                Detalle = detalle.Trim(),
                Insumos = ClonarDetalleFormula(insumos)
            };

            Formulas.Add(formula);
            ObtenerORegistrarStockFormula(formula.Nombre);
            return formula;
        }

        public static void ModificarFormula(string nombreActual, string nuevoNombre, string detalle, string estado, List<FormulaDetalle> insumos)
        {
            var formula = Formulas.First(f => f.Nombre == nombreActual);
            ValidarTexto(nuevoNombre, "nombre de la fórmula");
            ValidarDetalleFormula(insumos);

            if (!nombreActual.Equals(nuevoNombre.Trim(), StringComparison.OrdinalIgnoreCase) &&
                Formulas.Any(f => f.Nombre.Equals(nuevoNombre.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("Ya existe una fórmula con ese nombre.");
            }

            formula.Nombre = nuevoNombre.Trim();
            formula.Detalle = detalle.Trim();
            formula.Estado = estado;
            formula.Insumos = ClonarDetalleFormula(insumos);

            foreach (var orden in OrdenesProduccion.Where(o => o.Formula == nombreActual))
            {
                orden.Formula = formula.Nombre;
            }

            foreach (var salida in OrdenesSalidaInsumos.Where(o => ObtenerFormulaDeOrden(o.OrdenProduccionNumero) == nombreActual))
            {
                salida.Detalle = salida.Detalle;
            }

            foreach (var produccion in ProduccionesAlimento.Where(p => p.Formula == nombreActual))
            {
                produccion.Formula = formula.Nombre;
            }

            foreach (var nota in NotasIngresoAlimento.Where(n => n.Formula == nombreActual))
            {
                nota.Formula = formula.Nombre;
            }

            foreach (var item in StockAlimentos.Where(s => s.Formula == nombreActual))
            {
                item.Formula = formula.Nombre;
            }
        }

        public static OrdenProduccion RegistrarOrdenProduccion(DateTime fecha, string formula, double cantidadObjetivo, string detalle)
        {
            var formulaObj = Formulas.First(f => f.Nombre == formula && f.Estado == "Activo");
            ValidarCantidad(cantidadObjetivo, "La cantidad a producir debe ser mayor a cero.");

            var orden = new OrdenProduccion
            {
                Numero = GenerarCorrelativo("OP", OrdenesProduccion.Count + 1),
                Fecha = fecha,
                Formula = formulaObj.Nombre,
                CantidadObjetivo = cantidadObjetivo,
                Detalle = detalle.Trim()
            };

            OrdenesProduccion.Add(orden);
            SincronizarSolicitudesAbastecimiento(orden, string.Empty);
            return orden;
        }

        public static void CambiarEstadoOrden(string numeroOrden, string nuevoEstado)
        {
            OrdenesProduccion.First(o => o.Numero == numeroOrden).Estado = nuevoEstado;
        }

        public static OrdenSalidaInsumo RegistrarSalidaInsumosMolino(DateTime fecha, string numeroOrden, double cantidadAProcesar, string detalle)
        {
            var orden = OrdenesProduccion.First(o => o.Numero == numeroOrden);
            ValidarCantidad(cantidadAProcesar, "La cantidad a procesar debe ser mayor a cero.");

            double pendiente = orden.CantidadObjetivo - orden.CantidadProducida;
            if (cantidadAProcesar > pendiente)
            {
                throw new InvalidOperationException("La cantidad a procesar supera el pendiente de la orden.");
            }

            var requerimientos = CalcularRequerimientosFormula(orden.Formula, cantidadAProcesar)
                .Select(i => new DocumentoDetalle { Item = i.Insumo, Cantidad = i.Cantidad, Unidad = i.Unidad })
                .ToList();

            foreach (var req in requerimientos)
            {
                var insumo = Insumos.First(i => i.Nombre == req.Item && i.Estado == "Activo");
                if (insumo.StockDisponible < req.Cantidad)
                {
                    throw new InvalidOperationException($"No hay disponibilidad suficiente de {insumo.Nombre}.");
                }
            }

            var salida = new OrdenSalidaInsumo
            {
                Numero = GenerarCorrelativo("OSI", OrdenesSalidaInsumos.Count + 1),
                Fecha = fecha,
                OrdenProduccionNumero = orden.Numero,
                Detalle = detalle.Trim(),
                Detalles = ClonarDetalles(requerimientos)
            };

            foreach (var item in salida.Detalles)
            {
                var insumo = Insumos.First(i => i.Nombre == item.Item);
                insumo.StockDisponible -= item.Cantidad;
                RegistrarMovimientoInsumo(salida.Numero, fecha, "Salida a producción", insumo.Nombre, item.Cantidad, orden.Numero, detalle);
            }

            orden.Estado = "En proceso";
            OrdenesSalidaInsumos.Add(salida);
            return salida;
        }

        public static (OrdenSalidaInsumo salida, ProduccionAlimento produccion, NotaIngresoAlimento notaIngreso) RegistrarProduccionMolino(
            DateTime fecha,
            string numeroOrden,
            double cantidadProducida,
            string detalle)
        {
            var salida = RegistrarSalidaInsumosMolino(fecha, numeroOrden, cantidadProducida, detalle);
            var resultado = RegistrarProduccionMolinoConSalida(fecha, numeroOrden, cantidadProducida, salida.Numero, detalle);
            return (salida, resultado.produccion, resultado.notaIngreso);
        }

        private static (ProduccionAlimento produccion, NotaIngresoAlimento notaIngreso) RegistrarProduccionMolinoConSalida(
            DateTime fecha,
            string numeroOrden,
            double cantidadProducida,
            string numeroSalidaInsumo,
            string detalle)
        {
            var orden = OrdenesProduccion.First(o => o.Numero == numeroOrden);
            var salida = OrdenesSalidaInsumos.First(o => o.Numero == numeroSalidaInsumo);

            if (salida.OrdenProduccionNumero != orden.Numero)
            {
                throw new InvalidOperationException("La salida de insumos no pertenece a la orden seleccionada.");
            }

            ValidarCantidad(cantidadProducida, "La producción registrada debe ser mayor a cero.");

            if (orden.CantidadProducida + cantidadProducida > orden.CantidadObjetivo)
            {
                throw new InvalidOperationException("La producción excede la cantidad objetivo de la orden.");
            }

            var produccion = new ProduccionAlimento
            {
                Numero = GenerarCorrelativo("PAB", ProduccionesAlimento.Count + 1),
                Fecha = fecha,
                OrdenProduccionNumero = orden.Numero,
                OrdenSalidaInsumoNumero = salida.Numero,
                Formula = orden.Formula,
                CantidadProducida = cantidadProducida,
                Detalle = detalle.Trim()
            };

            var notaIngreso = new NotaIngresoAlimento
            {
                Numero = GenerarCorrelativo("NIA", NotasIngresoAlimento.Count + 1),
                Fecha = fecha,
                Formula = orden.Formula,
                OrdenProduccionNumero = orden.Numero,
                ProduccionNumero = produccion.Numero,
                Detalle = detalle.Trim(),
                Detalles = new List<DocumentoDetalle>
                {
                    new DocumentoDetalle
                    {
                        Item = orden.Formula,
                        Cantidad = cantidadProducida,
                        Unidad = "Sacos"
                    }
                }
            };

            var stock = ObtenerORegistrarStockFormula(orden.Formula);
            stock.StockDisponible += cantidadProducida;

            MovimientosAlimento.Add(new MovimientoAlimento
            {
                Documento = notaIngreso.Numero,
                Fecha = fecha,
                Tipo = "Ingreso a almacén",
                Formula = orden.Formula,
                Cantidad = cantidadProducida,
                StockResultante = stock.StockDisponible,
                Referencia = orden.Numero,
                Detalle = detalle.Trim()
            });

            orden.CantidadProducida += cantidadProducida;
            orden.Estado = Math.Abs(orden.CantidadProducida - orden.CantidadObjetivo) < 0.0001 ? "Completada" : "En proceso";

            ProduccionesAlimento.Add(produccion);
            NotasIngresoAlimento.Add(notaIngreso);
            return (produccion, notaIngreso);
        }

        public static OrdenProduccion GenerarOrdenPorStockInsuficiente(DateTime fecha, string formula, double cantidadObjetivo, string detalle)
        {
            return RegistrarOrdenProduccion(fecha, formula, cantidadObjetivo, $"Generada por stock insuficiente. {detalle}".Trim());
        }

        public static SolicitudAlimentoGalpon RegistrarSolicitudAlimento(DateTime fecha, string galpon, string formula, double cantidad, string detalle)
        {
            var galponObj = Galpones.FirstOrDefault(g => g.Nombre == galpon && g.Estado == "Activo");
            if (galponObj == null)
            {
                throw new InvalidOperationException("La solicitud debe pertenecer a un galpón activo.");
            }

            var formulaObj = Formulas.FirstOrDefault(f => f.Nombre == formula && f.Estado == "Activo");
            if (formulaObj == null)
            {
                throw new InvalidOperationException("La solicitud debe usar una fórmula activa.");
            }

            ValidarCantidad(cantidad, "La cantidad solicitada debe ser mayor a cero.");

            var solicitud = new SolicitudAlimentoGalpon
            {
                Numero = GenerarCorrelativo("SAG", SolicitudesAlimentoGalpones.Count + 1),
                Fecha = fecha,
                Galpon = galponObj.Nombre,
                Formula = formulaObj.Nombre,
                Cantidad = cantidad,
                Detalle = detalle.Trim()
            };

            double coberturaDisponible = ObtenerStockAlimento(formulaObj.Nombre) + ObtenerProduccionPendienteFormula(formulaObj.Nombre);
            double faltante = Math.Max(cantidad - coberturaDisponible, 0);
            if (faltante > 0)
            {
                var orden = RegistrarOrdenProduccion(
                    fecha,
                    formulaObj.Nombre,
                    faltante,
                    $"Generada automáticamente por solicitud {solicitud.Numero} del {galponObj.Nombre}. {detalle}".Trim());

                solicitud.OrdenProduccionGenerada = orden.Numero;
            }

            SolicitudesAlimentoGalpones.Add(solicitud);
            return solicitud;
        }

        public static (OrdenSalidaAlmacenAlimento salida, OrdenIngresoDistribucion ingreso) RegistrarDistribucion(
            DateTime fecha,
            string galpon,
            string formula,
            double cantidad,
            string detalle,
            string solicitudNumero = "")
        {
            var galponObj = Galpones.FirstOrDefault(g => g.Nombre == galpon && g.Estado == "Activo");
            if (galponObj == null)
            {
                throw new InvalidOperationException("La distribución solo puede realizarse a un galpón activo.");
            }

            var stock = ObtenerORegistrarStockFormula(formula);
            ValidarCantidad(cantidad, "La cantidad distribuida debe ser mayor a cero.");

            if (stock.StockDisponible < cantidad)
            {
                throw new InvalidOperationException("No hay suficiente alimento balanceado disponible.");
            }

            var detalles = new List<DocumentoDetalle>
            {
                new DocumentoDetalle
                {
                    Item = formula,
                    Cantidad = cantidad,
                    Unidad = "Sacos"
                }
            };

            var salida = new OrdenSalidaAlmacenAlimento
            {
                Numero = GenerarCorrelativo("OSA", OrdenesSalidaAlmacen.Count + 1),
                Fecha = fecha,
                Formula = formula,
                SolicitudNumero = solicitudNumero,
                Detalle = detalle.Trim(),
                Detalles = ClonarDetalles(detalles)
            };

            var ingreso = new OrdenIngresoDistribucion
            {
                Numero = GenerarCorrelativo("OID", OrdenesIngresoDistribucion.Count + 1),
                Fecha = fecha,
                Galpon = galponObj.Nombre,
                Formula = formula,
                OrdenSalidaAlmacenNumero = salida.Numero,
                SolicitudNumero = solicitudNumero,
                Detalle = detalle.Trim(),
                Detalles = ClonarDetalles(detalles)
            };

            stock.StockDisponible -= cantidad;

            MovimientosAlimento.Add(new MovimientoAlimento
            {
                Documento = salida.Numero,
                Fecha = fecha,
                Tipo = "Salida a distribución",
                Formula = formula,
                Cantidad = -cantidad,
                StockResultante = stock.StockDisponible,
                Referencia = solicitudNumero,
                Galpon = galponObj.Nombre,
                Detalle = detalle.Trim()
            });

            if (!string.IsNullOrWhiteSpace(solicitudNumero))
            {
                var solicitud = SolicitudesAlimentoGalpones.FirstOrDefault(s => s.Numero == solicitudNumero);
                if (solicitud != null)
                {
                    solicitud.Estado = "Atendida";
                }
            }

            OrdenesSalidaAlmacen.Add(salida);
            OrdenesIngresoDistribucion.Add(ingreso);
            return (salida, ingreso);
        }

        public static IEnumerable<Insumo> ObtenerInsumosCriticos()
        {
            return Insumos.Where(i => i.Estado == "Activo" && i.StockDisponible <= i.StockMinimo).OrderBy(i => i.Nombre);
        }

        public static IEnumerable<StockAlimentoBalanceado> ObtenerStockAlimentoInsuficiente()
        {
            return StockAlimentos.Where(s => s.StockDisponible <= 20).OrderBy(s => s.Formula);
        }

        public static string ObtenerResumenAlertas()
        {
            var alertas = new List<string>();

            if (ObtenerInsumosCriticos().Any())
            {
                alertas.Add("Hay insumos en stock mínimo.");
            }

            if (ObtenerStockAlimentoInsuficiente().Any())
            {
                alertas.Add("Hay fórmulas con alimento insuficiente.");
            }

            if (OrdenesProduccion.Any(o => o.Estado == "Pendiente"))
            {
                alertas.Add("Hay órdenes de producción pendientes.");
            }

            if (SolicitudesAlimentoGalpones.Any(s => s.Estado == "Pendiente"))
            {
                alertas.Add("Hay solicitudes de distribución pendientes.");
            }

            return alertas.Any() ? string.Join(" ", alertas) : "Sin alertas críticas.";
        }

        public static string ObtenerUnidadInsumo(string nombreInsumo)
        {
            return Insumos.FirstOrDefault(i => i.Nombre == nombreInsumo)?.Unidad ?? "KG";
        }

        public static double ObtenerStockAlimento(string formula)
        {
            return ObtenerORegistrarStockFormula(formula).StockDisponible;
        }

        public static List<FormulaDetalle> CalcularRequerimientosFormula(string formula, double cantidadObjetivo)
        {
            var formulaObj = Formulas.First(f => f.Nombre == formula);
            return formulaObj.Insumos
                .Select(i => new FormulaDetalle
                {
                    Insumo = i.Insumo,
                    Cantidad = Math.Round(i.Cantidad * cantidadObjetivo / CapacidadBaseFormulaSacos, 2),
                    Unidad = i.Unidad
                })
                .ToList();
        }

        public static SolicitudAbastecimientoInsumo? ObtenerSolicitudAbastecimiento(string numeroSolicitud)
        {
            return SolicitudesAbastecimientoInsumos.FirstOrDefault(s => s.Numero == numeroSolicitud);
        }

        public static List<DocumentoDetalle> ObtenerDetalleDocumento(string numeroDocumento)
        {
            var ingresoInsumo = NotasIngresoInsumos.FirstOrDefault(n => n.Numero == numeroDocumento);
            if (ingresoInsumo != null) return ClonarDetalles(ingresoInsumo.Detalles);

            var salidaInsumo = OrdenesSalidaInsumos.FirstOrDefault(n => n.Numero == numeroDocumento);
            if (salidaInsumo != null) return ClonarDetalles(salidaInsumo.Detalles);

            var ingresoAlimento = NotasIngresoAlimento.FirstOrDefault(n => n.Numero == numeroDocumento);
            if (ingresoAlimento != null) return ClonarDetalles(ingresoAlimento.Detalles);

            var salidaAlmacen = OrdenesSalidaAlmacen.FirstOrDefault(n => n.Numero == numeroDocumento);
            if (salidaAlmacen != null) return ClonarDetalles(salidaAlmacen.Detalles);

            var ingresoDistribucion = OrdenesIngresoDistribucion.FirstOrDefault(n => n.Numero == numeroDocumento);
            if (ingresoDistribucion != null) return ClonarDetalles(ingresoDistribucion.Detalles);

            return new List<DocumentoDetalle>();
        }

        public static string ObtenerResumenDocumento(string numeroDocumento)
        {
            var ingresoInsumo = NotasIngresoInsumos.FirstOrDefault(n => n.Numero == numeroDocumento);
            if (ingresoInsumo != null) return $"{ingresoInsumo.Fecha:dd/MM/yyyy} | Proveedor: {ingresoInsumo.Proveedor}";

            var salidaInsumo = OrdenesSalidaInsumos.FirstOrDefault(n => n.Numero == numeroDocumento);
            if (salidaInsumo != null) return $"{salidaInsumo.Fecha:dd/MM/yyyy} | Orden: {salidaInsumo.OrdenProduccionNumero}";

            var ingresoAlimento = NotasIngresoAlimento.FirstOrDefault(n => n.Numero == numeroDocumento);
            if (ingresoAlimento != null) return $"{ingresoAlimento.Fecha:dd/MM/yyyy} | Fórmula: {ingresoAlimento.Formula}";

            var salidaAlmacen = OrdenesSalidaAlmacen.FirstOrDefault(n => n.Numero == numeroDocumento);
            if (salidaAlmacen != null) return $"{salidaAlmacen.Fecha:dd/MM/yyyy} | Destino: Distribución";

            var ingresoDistribucion = OrdenesIngresoDistribucion.FirstOrDefault(n => n.Numero == numeroDocumento);
            if (ingresoDistribucion != null) return $"{ingresoDistribucion.Fecha:dd/MM/yyyy} | Galpón: {ingresoDistribucion.Galpon}";

            return string.Empty;
        }

        private static void RegistrarMovimientoInsumo(string documento, DateTime fecha, string tipo, string insumo, double cantidad, string referencia, string detalle)
        {
            var insumoObj = Insumos.First(i => i.Nombre == insumo);
            MovimientosInsumos.Add(new MovimientoInsumo
            {
                Documento = documento,
                Fecha = fecha,
                Tipo = tipo,
                Insumo = insumoObj.Nombre,
                Cantidad = cantidad,
                Unidad = insumoObj.Unidad,
                StockResultante = insumoObj.StockDisponible,
                Referencia = referencia,
                Detalle = detalle.Trim()
            });
        }

        private static SolicitudAbastecimientoInsumo RegistrarSolicitudAbastecimientoInterna(
            DateTime fecha,
            string insumo,
            double cantidad,
            string detalle,
            string formula,
            string galpon,
            string ordenProduccionNumero)
        {
            var solicitud = new SolicitudAbastecimientoInsumo
            {
                Numero = GenerarCorrelativo("SAI", SolicitudesAbastecimientoInsumos.Count + 1),
                Fecha = fecha,
                Insumo = insumo,
                Cantidad = Math.Round(cantidad, 2),
                Formula = formula,
                Galpon = galpon,
                OrdenProduccionNumero = ordenProduccionNumero,
                Detalle = detalle.Trim()
            };

            SolicitudesAbastecimientoInsumos.Add(solicitud);
            return solicitud;
        }

        private static double ObtenerProduccionPendienteFormula(string formula)
        {
            return OrdenesProduccion
                .Where(o => o.Formula == formula && o.Estado != "Inhabilitada")
                .Sum(o => Math.Max(o.CantidadObjetivo - o.CantidadProducida, 0));
        }

        private static double ObtenerAbastecimientoPendienteInsumo(string insumo)
        {
            return SolicitudesAbastecimientoInsumos
                .Where(s => s.Insumo == insumo && s.Estado == "Pendiente")
                .Sum(s => s.Cantidad);
        }

        private static double ObtenerDemandaAbiertaInsumo(string insumo)
        {
            return OrdenesProduccion
                .Where(o => o.Estado != "Inhabilitada")
                .SelectMany(o => CalcularRequerimientosFormula(o.Formula, Math.Max(o.CantidadObjetivo - o.CantidadProducida, 0)))
                .Where(r => r.Insumo == insumo)
                .Sum(r => r.Cantidad);
        }

        private static void SincronizarSolicitudesAbastecimiento(OrdenProduccion orden, string galpon)
        {
            foreach (var item in CalcularRequerimientosFormula(orden.Formula, Math.Max(orden.CantidadObjetivo - orden.CantidadProducida, 0)))
            {
                var insumo = Insumos.First(i => i.Nombre == item.Insumo && i.Estado == "Activo");
                double demandaAbierta = ObtenerDemandaAbiertaInsumo(insumo.Nombre);
                double cobertura = insumo.StockDisponible + ObtenerAbastecimientoPendienteInsumo(insumo.Nombre);
                double faltante = Math.Round(demandaAbierta - cobertura, 2);

                if (faltante <= 0)
                {
                    continue;
                }

                RegistrarSolicitudAbastecimientoInterna(
                    orden.Fecha,
                    insumo.Nombre,
                    faltante,
                    $"Abastecimiento requerido para {orden.Formula} ({orden.Numero}).",
                    orden.Formula,
                    galpon,
                    orden.Numero);
            }
        }

        private static void ValidarTexto(string valor, string campo)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new InvalidOperationException($"Debe ingresar el {campo}.");
            }
        }

        private static void ValidarCantidad(double cantidad, string mensaje)
        {
            if (cantidad <= 0)
            {
                throw new InvalidOperationException(mensaje);
            }
        }

        private static void ValidarDetalleFormula(List<FormulaDetalle> insumos)
        {
            if (insumos == null || !insumos.Any())
            {
                throw new InvalidOperationException("La fórmula debe tener al menos un insumo asociado.");
            }

            if (insumos.Any(i => string.IsNullOrWhiteSpace(i.Insumo) || i.Cantidad <= 0))
            {
                throw new InvalidOperationException("Todos los insumos de la fórmula deben tener nombre y cantidad válida.");
            }
        }

        private static void ValidarDetalleDocumento(List<DocumentoDetalle> detalles, string mensaje)
        {
            if (detalles == null || !detalles.Any())
            {
                throw new InvalidOperationException(mensaje);
            }

            if (detalles.Any(d => string.IsNullOrWhiteSpace(d.Item) || d.Cantidad <= 0))
            {
                throw new InvalidOperationException("Todos los detalles del documento deben tener item y cantidad válida.");
            }
        }

        private static List<DocumentoDetalle> ClonarDetalles(List<DocumentoDetalle> detalles)
        {
            return detalles
                .Select(d => new DocumentoDetalle
                {
                    Item = d.Item,
                    Cantidad = d.Cantidad,
                    Unidad = d.Unidad
                })
                .ToList();
        }

        private static List<FormulaDetalle> ClonarDetalleFormula(List<FormulaDetalle> detalles)
        {
            return detalles
                .Select(d => new FormulaDetalle
                {
                    Insumo = d.Insumo,
                    Cantidad = d.Cantidad,
                    Unidad = d.Unidad
                })
                .ToList();
        }

        private static StockAlimentoBalanceado ObtenerORegistrarStockFormula(string formula)
        {
            var stock = StockAlimentos.FirstOrDefault(s => s.Formula == formula);
            if (stock == null)
            {
                stock = new StockAlimentoBalanceado { Formula = formula, StockDisponible = 0 };
                StockAlimentos.Add(stock);
            }

            return stock;
        }

        private static string GenerarCorrelativo(string prefijo, int correlativo)
        {
            return $"{prefijo}-{correlativo:0000}";
        }

        private static string ObtenerFormulaDeOrden(string numeroOrden)
        {
            return OrdenesProduccion.First(o => o.Numero == numeroOrden).Formula;
        }

        private static void InicializarDatosDemo()
        {
            Galpones.AddRange(new[]
            {
                new Galpon { Nombre = "Galpón 1", Estado = "Activo", Observaciones = "Línea principal" },
                new Galpon { Nombre = "Galpón 2", Estado = "Activo", Observaciones = "Línea secundaria" },
                new Galpon { Nombre = "Galpón 3", Estado = "Activo", Observaciones = "Reserva" }
            });

            Insumos.AddRange(new[]
            {
                new Insumo { Nombre = "Maíz", Unidad = "KG", StockDisponible = 0, StockMinimo = 1200, Estado = "Activo", Observaciones = "Base energética" },
                new Insumo { Nombre = "Torta de Soya", Unidad = "KG", StockDisponible = 0, StockMinimo = 400, Estado = "Activo", Observaciones = "Proteína vegetal" },
                new Insumo { Nombre = "Polvillo", Unidad = "KG", StockDisponible = 0, StockMinimo = 120, Estado = "Activo", Observaciones = "" },
                new Insumo { Nombre = "Palmiste", Unidad = "KG", StockDisponible = 0, StockMinimo = 100, Estado = "Activo", Observaciones = "" },
                new Insumo { Nombre = "Cal. Fino", Unidad = "KG", StockDisponible = 0, StockMinimo = 80, Estado = "Activo", Observaciones = "" },
                new Insumo { Nombre = "Cal. Grueso", Unidad = "KG", StockDisponible = 0, StockMinimo = 120, Estado = "Activo", Observaciones = "" },
                new Insumo { Nombre = "Aceite", Unidad = "L", StockDisponible = 0, StockMinimo = 20, Estado = "Activo", Observaciones = "" },
                new Insumo { Nombre = "Sal", Unidad = "KG", StockDisponible = 0, StockMinimo = 20, Estado = "Activo", Observaciones = "" },
                new Insumo { Nombre = "Phosbic", Unidad = "KG", StockDisponible = 0, StockMinimo = 30, Estado = "Activo", Observaciones = "" },
                new Insumo { Nombre = "Pre Postura", Unidad = "KG", StockDisponible = 0, StockMinimo = 10, Estado = "Activo", Observaciones = "" },
                new Insumo { Nombre = "Pre Levante", Unidad = "KG", StockDisponible = 0, StockMinimo = 10, Estado = "Activo", Observaciones = "" },
                new Insumo { Nombre = "Metionina", Unidad = "KG", StockDisponible = 0, StockMinimo = 10, Estado = "Activo", Observaciones = "" },
                new Insumo { Nombre = "Lisina", Unidad = "KG", StockDisponible = 0, StockMinimo = 10, Estado = "Activo", Observaciones = "" },
                new Insumo { Nombre = "Bio Colina", Unidad = "KG", StockDisponible = 0, StockMinimo = 10, Estado = "Activo", Observaciones = "" },
                new Insumo { Nombre = "Bicarbonato", Unidad = "KG", StockDisponible = 0, StockMinimo = 20, Estado = "Activo", Observaciones = "" },
                new Insumo { Nombre = "Neomicina", Unidad = "KG", StockDisponible = 0, StockMinimo = 10, Estado = "Activo", Observaciones = "" },
                new Insumo { Nombre = "Secuestrante", Unidad = "KG", StockDisponible = 0, StockMinimo = 20, Estado = "Activo", Observaciones = "" },
                new Insumo { Nombre = "Treonina", Unidad = "KG", StockDisponible = 0, StockMinimo = 10, Estado = "Activo", Observaciones = "" },
                new Insumo { Nombre = "Liptosa", Unidad = "KG", StockDisponible = 0, StockMinimo = 10, Estado = "Activo", Observaciones = "" }
            });

            Formulas.AddRange(new[]
            {
                new FormulaAlimento
                {
                    Nombre = "Desarrollo",
                    Estado = "Activo",
                    Detalle = "Fórmula base para 30 sacos",
                    Insumos = new List<FormulaDetalle>
                    {
                        new FormulaDetalle { Insumo = "Maíz", Cantidad = 926, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Torta de Soya", Cantidad = 330, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Polvillo", Cantidad = 50, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Palmiste", Cantidad = 63, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Cal. Fino", Cantidad = 40, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Cal. Grueso", Cantidad = 50, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Aceite", Cantidad = 4.5, Unidad = "L" },
                        new FormulaDetalle { Insumo = "Sal", Cantidad = 3.8, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Phosbic", Cantidad = 17, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Pre Levante", Cantidad = 1.75, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Metionina", Cantidad = 2.8, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Lisina", Cantidad = 2.2, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Bio Colina", Cantidad = 0.75, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Bicarbonato", Cantidad = 3.8, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Neomicina", Cantidad = 0.45, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Secuestrante", Cantidad = 2.5, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Treonina", Cantidad = 1, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Liptosa", Cantidad = 1, Unidad = "KG" }
                    }
                },
                new FormulaAlimento
                {
                    Nombre = "Postura 1",
                    Estado = "Activo",
                    Detalle = "Fórmula base para 30 sacos",
                    Insumos = new List<FormulaDetalle>
                    {
                        new FormulaDetalle { Insumo = "Maíz", Cantidad = 823, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Torta de Soya", Cantidad = 338, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Polvillo", Cantidad = 75, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Palmiste", Cantidad = 80, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Cal. Fino", Cantidad = 48, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Cal. Grueso", Cantidad = 103, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Aceite", Cantidad = 4.5, Unidad = "L" },
                        new FormulaDetalle { Insumo = "Sal", Cantidad = 4.2, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Phosbic", Cantidad = 9, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Pre Postura", Cantidad = 1.5, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Metionina", Cantidad = 3.6, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Lisina", Cantidad = 1.8, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Bio Colina", Cantidad = 0.45, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Bicarbonato", Cantidad = 4, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Neomicina", Cantidad = 0.4, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Secuestrante", Cantidad = 2.5, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Treonina", Cantidad = 0.6, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Liptosa", Cantidad = 0.75, Unidad = "KG" }
                    }
                },
                new FormulaAlimento
                {
                    Nombre = "Postura 2",
                    Estado = "Activo",
                    Detalle = "Fórmula base para 30 sacos",
                    Insumos = new List<FormulaDetalle>
                    {
                        new FormulaDetalle { Insumo = "Maíz", Cantidad = 851, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Torta de Soya", Cantidad = 300, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Polvillo", Cantidad = 75, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Palmiste", Cantidad = 80, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Cal. Fino", Cantidad = 35, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Cal. Grueso", Cantidad = 126, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Aceite", Cantidad = 4.5, Unidad = "L" },
                        new FormulaDetalle { Insumo = "Sal", Cantidad = 5, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Phosbic", Cantidad = 7.5, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Pre Postura", Cantidad = 1.5, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Metionina", Cantidad = 3.5, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Lisina", Cantidad = 1.8, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Bio Colina", Cantidad = 0.45, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Bicarbonato", Cantidad = 4.5, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Neomicina", Cantidad = 0.4, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Secuestrante", Cantidad = 2.5, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Treonina", Cantidad = 0.5, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Liptosa", Cantidad = 0.75, Unidad = "KG" }
                    }
                },
                new FormulaAlimento
                {
                    Nombre = "Postura 3",
                    Estado = "Activo",
                    Detalle = "Fórmula base para 30 sacos",
                    Insumos = new List<FormulaDetalle>
                    {
                        new FormulaDetalle { Insumo = "Maíz", Cantidad = 884, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Torta de Soya", Cantidad = 270, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Polvillo", Cantidad = 75, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Palmiste", Cantidad = 75, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Cal. Fino", Cantidad = 35, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Cal. Grueso", Cantidad = 130, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Aceite", Cantidad = 3, Unidad = "L" },
                        new FormulaDetalle { Insumo = "Sal", Cantidad = 5.2, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Phosbic", Cantidad = 8.1, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Pre Postura", Cantidad = 1.5, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Metionina", Cantidad = 3.1, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Lisina", Cantidad = 2.1, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Bio Colina", Cantidad = 0.45, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Bicarbonato", Cantidad = 3.75, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Neomicina", Cantidad = 0.4, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Secuestrante", Cantidad = 2.5, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Treonina", Cantidad = 0.45, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Liptosa", Cantidad = 0.75, Unidad = "KG" }
                    }
                },
                new FormulaAlimento
                {
                    Nombre = "Engorde",
                    Estado = "Activo",
                    Detalle = "Fórmula base para 30 sacos",
                    Insumos = new List<FormulaDetalle>
                    {
                        new FormulaDetalle { Insumo = "Maíz", Cantidad = 886, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Torta de Soya", Cantidad = 250, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Polvillo", Cantidad = 90, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Palmiste", Cantidad = 70, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Cal. Fino", Cantidad = 30, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Cal. Grueso", Cantidad = 135, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Aceite", Cantidad = 10, Unidad = "L" },
                        new FormulaDetalle { Insumo = "Sal", Cantidad = 5.2, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Phosbic", Cantidad = 8.1, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Pre Postura", Cantidad = 1.5, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Metionina", Cantidad = 3.1, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Lisina", Cantidad = 2.1, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Bio Colina", Cantidad = 0.45, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Bicarbonato", Cantidad = 3.75, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Neomicina", Cantidad = 0.4, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Secuestrante", Cantidad = 2.5, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Treonina", Cantidad = 0.45, Unidad = "KG" },
                        new FormulaDetalle { Insumo = "Liptosa", Cantidad = 0.75, Unidad = "KG" }
                    }
                }
            });

            foreach (var formula in Formulas)
            {
                StockAlimentos.Add(new StockAlimentoBalanceado { Formula = formula.Nombre, StockDisponible = 0 });
            }

            var notaIngreso = RegistrarNotaIngresoInsumo(
                DateTime.Today.AddDays(-4),
                "Proveedor Central",
                "Ingreso inicial de insumos",
                new List<DocumentoDetalle>
                {
                    new DocumentoDetalle { Item = "Maíz", Cantidad = 20000, Unidad = "KG" },
                    new DocumentoDetalle { Item = "Torta de Soya", Cantidad = 7000, Unidad = "KG" },
                    new DocumentoDetalle { Item = "Polvillo", Cantidad = 1500, Unidad = "KG" },
                    new DocumentoDetalle { Item = "Palmiste", Cantidad = 1500, Unidad = "KG" },
                    new DocumentoDetalle { Item = "Cal. Fino", Cantidad = 1200, Unidad = "KG" },
                    new DocumentoDetalle { Item = "Cal. Grueso", Cantidad = 2000, Unidad = "KG" },
                    new DocumentoDetalle { Item = "Aceite", Cantidad = 250, Unidad = "L" },
                    new DocumentoDetalle { Item = "Sal", Cantidad = 180, Unidad = "KG" },
                    new DocumentoDetalle { Item = "Phosbic", Cantidad = 300, Unidad = "KG" },
                    new DocumentoDetalle { Item = "Pre Postura", Cantidad = 60, Unidad = "KG" },
                    new DocumentoDetalle { Item = "Pre Levante", Cantidad = 60, Unidad = "KG" },
                    new DocumentoDetalle { Item = "Metionina", Cantidad = 120, Unidad = "KG" },
                    new DocumentoDetalle { Item = "Lisina", Cantidad = 90, Unidad = "KG" },
                    new DocumentoDetalle { Item = "Bio Colina", Cantidad = 40, Unidad = "KG" },
                    new DocumentoDetalle { Item = "Bicarbonato", Cantidad = 200, Unidad = "KG" },
                    new DocumentoDetalle { Item = "Neomicina", Cantidad = 25, Unidad = "KG" },
                    new DocumentoDetalle { Item = "Secuestrante", Cantidad = 90, Unidad = "KG" },
                    new DocumentoDetalle { Item = "Treonina", Cantidad = 40, Unidad = "KG" },
                    new DocumentoDetalle { Item = "Liptosa", Cantidad = 40, Unidad = "KG" }
                });

            RegistrarSolicitudAbastecimiento(DateTime.Today.AddDays(-2), "Cal. Grueso", 120, "Reabastecimiento preventivo");

            var orden = RegistrarOrdenProduccion(DateTime.Today.AddDays(-2), "Postura 1", 20, "Reposición semanal");
            RegistrarProduccionMolino(DateTime.Today.AddDays(-2), orden.Numero, 20, "Producción completada");

            var ordenPendiente = RegistrarOrdenProduccion(DateTime.Today.AddDays(-1), "Engorde", 25, "Pendiente por atender");
            CambiarEstadoOrden(ordenPendiente.Numero, "Pendiente");

            var solicitud = RegistrarSolicitudAlimento(DateTime.Today, "Galpón 1", "Postura 1", 12, "Necesidad del turno mañana");
            RegistrarDistribucion(DateTime.Today, "Galpón 1", "Postura 1", 8, "Primer despacho del día", solicitud.Numero);
        }
    }
}
