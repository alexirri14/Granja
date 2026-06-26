using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Granja
{
    public partial class Reportes : Form
    {
        private enum TipoReporte
        {
            MovimientosInsumos,
            Ordenes,
            Produccion,
            Distribucion
        }

        private enum TipoGrafico
        {
            Barras,
            Lineas,
            Torta,
            Dona
        }

        private sealed class DatosReporte
        {
            public string Titulo { get; set; } = string.Empty;
            public string Descripcion { get; set; } = string.Empty;
            public string EtiquetaCategoria { get; set; } = "Categoría";
            public string SerieNombre { get; set; } = string.Empty;
            public TipoGrafico TipoGrafico { get; set; }
            public List<string> Categorias { get; set; } = new();
            public List<string> Encabezados { get; set; } = new();
            public List<string[]> Filas { get; set; } = new();
            public List<(string Etiqueta, double Valor)> PuntosGrafico { get; set; } = new();
        }

        private Button btnActivo = null!;
        private TipoReporte reporteActual = TipoReporte.MovimientosInsumos;
        private bool actualizandoFiltros;
        private DatosReporte? datosActuales;

        public Reportes()
        {
            InitializeComponent();
            ConfigurarVista();
            btnActivo = btnReporteMovimientosInsumos;
            InicializarPanelReporte();
            CargarReporte(true);

            btnReporteMovimientosInsumos.Click += (s, e) => CambiarReporte(btnReporteMovimientosInsumos, TipoReporte.MovimientosInsumos);
            btnReporteOrdenes.Click += (s, e) => CambiarReporte(btnReporteOrdenes, TipoReporte.Ordenes);
            btnReporteProduccion.Click += (s, e) => CambiarReporte(btnReporteProduccion, TipoReporte.Produccion);
            btnReporteDistribucion.Click += (s, e) => CambiarReporte(btnReporteDistribucion, TipoReporte.Distribucion);
        }

        private void ConfigurarVista()
        {
            UiHelper.ConfigurarTituloGeneral(lblTitle);
            UiHelper.ConfigurarNavegacion(panelNav, btnDashboard, btnProduccion, btnAlmacen, btnVentas, btnAlimento, btnInsumos, btnMolino, btnReportes, btnReportes);

            lblReportesTitle.Text = "Centro de Reportes";
            btnReporteMovimientosInsumos.Text = "Mov. insumos";
            btnReporteOrdenes.Text = "Órdenes";
            btnReporteProduccion.Text = "Producción";
            btnReporteDistribucion.Text = "Distribución";

            panelMain.AutoScroll = false;
            panelTabs.Location = new Point(34, 100);
            panelTabs.Size = new Size(1189, 76);
            panelTabs.Padding = new Padding(18);

            btnReporteMovimientosInsumos.Location = new Point(18, 18);
            btnReporteMovimientosInsumos.Size = new Size(175, 40);
            btnReporteOrdenes.Location = new Point(205, 18);
            btnReporteOrdenes.Size = new Size(175, 40);
            btnReporteProduccion.Location = new Point(392, 18);
            btnReporteProduccion.Size = new Size(175, 40);
            btnReporteDistribucion.Location = new Point(579, 18);
            btnReporteDistribucion.Size = new Size(175, 40);

            panelContenido.Location = new Point(34, 190);
            panelContenido.Size = new Size(1189, 560);
            panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void InicializarPanelReporte()
        {
            panelReporte.BackColor = Color.White;
            panelReporte.Padding = new Padding(16);

            panelFiltros.Dock = DockStyle.Top;
            panelFiltros.Height = 122;
            panelFiltros.BackColor = Color.WhiteSmoke;

            lblTituloReporte.AutoSize = true;
            lblTituloReporte.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloReporte.ForeColor = Color.FromArgb(26, 32, 44);
            lblTituloReporte.Location = new Point(16, 12);

            lblDescripcionReporte.AutoSize = true;
            lblDescripcionReporte.ForeColor = Color.FromArgb(90, 104, 119);
            lblDescripcionReporte.Location = new Point(18, 48);

            lblFiltroDesde.AutoSize = true;
            lblFiltroDesde.Text = "Desde";
            lblFiltroDesde.Location = new Point(18, 78);

            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(70, 74);
            dtpDesde.Width = 120;
            dtpDesde.Value = DateTime.Today.AddMonths(-1);
            dtpDesde.ValueChanged += (_, _) => CargarReporte();

            lblFiltroHasta.AutoSize = true;
            lblFiltroHasta.Text = "Hasta";
            lblFiltroHasta.Location = new Point(208, 78);

            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(258, 74);
            dtpHasta.Width = 120;
            dtpHasta.Value = DateTime.Today;
            dtpHasta.ValueChanged += (_, _) => CargarReporte();

            lblFiltroCategoria.AutoSize = true;
            lblFiltroCategoria.Text = "Categoría";
            lblFiltroCategoria.Location = new Point(400, 78);

            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Location = new Point(475, 74);
            cmbCategoria.Width = 210;
            cmbCategoria.SelectedIndexChanged += (_, _) =>
            {
                if (!actualizandoFiltros)
                {
                    CargarReporte();
                }
            };

            btnLimpiarFiltros.Text = "Limpiar filtros";
            btnLimpiarFiltros.Location = new Point(705, 70);
            btnLimpiarFiltros.Size = new Size(130, 34);
            btnLimpiarFiltros.Click += (_, _) =>
            {
                dtpDesde.Value = DateTime.Today.AddMonths(-1);
                dtpHasta.Value = DateTime.Today;
                if (cmbCategoria.Items.Count > 0)
                {
                    cmbCategoria.SelectedIndex = 0;
                }
                CargarReporte();
            };

            btnExportarExcel.Text = "Exportar Excel";
            btnExportarExcel.Location = new Point(856, 70);
            btnExportarExcel.Size = new Size(140, 34);
            btnExportarExcel.Click += (_, _) => ExportarExcel();

            btnExportarPdf.Text = "Exportar PDF";
            btnExportarPdf.Location = new Point(1010, 70);
            btnExportarPdf.Size = new Size(140, 34);
            btnExportarPdf.Click += (_, _) => ExportarPdf();
            panelFiltros.Resize += (_, _) => AcomodarFiltros();

            splitReporte.Dock = DockStyle.Fill;
            splitReporte.Orientation = Orientation.Horizontal;
            splitReporte.SplitterDistance = 250;
            splitReporte.Panel1.BackColor = Color.White;
            splitReporte.Panel2.BackColor = Color.White;
            splitReporte.Location = new Point(16, 138);

            splitReporte.Panel1.Padding = new Padding(12, 8, 12, 12);
            splitReporte.Panel2.Padding = new Padding(12, 8, 12, 12);

            picGrafico.BackColor = Color.White;
            picGrafico.Dock = DockStyle.Fill;
            picGrafico.SizeMode = PictureBoxSizeMode.Zoom;

            lblResumen.AutoSize = false;
            lblResumen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResumen.ForeColor = Color.FromArgb(0, 125, 62);
            lblResumen.Dock = DockStyle.Top;
            lblResumen.Height = 28;

            dgvReporte.Dock = DockStyle.Fill;
            dgvReporte.BackgroundColor = Color.White;
            dgvReporte.BorderStyle = BorderStyle.None;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AllowUserToDeleteRows = false;
            dgvReporte.ReadOnly = true;
            dgvReporte.RowHeadersVisible = false;
            picGrafico.Resize += (_, _) =>
            {
                if (datosActuales != null && picGrafico.Width > 0 && picGrafico.Height > 0)
                {
                    CargarGrafico(datosActuales);
                }
            };
            splitReporte.Resize += (_, _) =>
            {
                if (datosActuales != null)
                {
                    CargarGrafico(datosActuales);
                }
            };

            AcomodarFiltros();
        }

        private void AcomodarFiltros()
        {
            int y = 74;
            int ancho = panelFiltros.ClientSize.Width;
            int derecha = Math.Max(ancho - 18, 900);

            btnExportarPdf.Location = new Point(derecha - btnExportarPdf.Width, 70);
            btnExportarExcel.Location = new Point(btnExportarPdf.Left - btnExportarExcel.Width - 10, 70);
            btnLimpiarFiltros.Location = new Point(btnExportarExcel.Left - btnLimpiarFiltros.Width - 14, 70);

            lblFiltroDesde.Location = new Point(18, y + 4);
            dtpDesde.Location = new Point(70, y);
            lblFiltroHasta.Location = new Point(208, y + 4);
            dtpHasta.Location = new Point(258, y);
            lblFiltroCategoria.Location = new Point(400, y + 4);

            int anchoCategoria = Math.Max(180, btnLimpiarFiltros.Left - 490);
            cmbCategoria.Location = new Point(475, y);
            cmbCategoria.Width = anchoCategoria;
        }

        private void CambiarReporte(Button btnSeleccionado, TipoReporte tipoReporte)
        {
            btnActivo.BackColor = Color.FromArgb(230, 230, 230);
            btnActivo.ForeColor = Color.FromArgb(44, 62, 80);

            btnSeleccionado.BackColor = Color.FromArgb(0, 125, 62);
            btnSeleccionado.ForeColor = Color.White;

            btnActivo = btnSeleccionado;
            reporteActual = tipoReporte;
            CargarReporte(true);
        }

        private void CargarReporte(bool reiniciarCategoria = false)
        {
            datosActuales = ConstruirDatosReporte();
            lblTituloReporte.Text = datosActuales.Titulo;
            lblDescripcionReporte.Text = datosActuales.Descripcion;
            lblFiltroCategoria.Text = datosActuales.EtiquetaCategoria;
            CargarCategorias(reiniciarCategoria, datosActuales.Categorias);

            dgvReporte.Columns.Clear();
            dgvReporte.Rows.Clear();
            foreach (var encabezado in datosActuales.Encabezados)
            {
                dgvReporte.Columns.Add(encabezado, encabezado);
            }

            foreach (var fila in datosActuales.Filas)
            {
                dgvReporte.Rows.Add(fila);
            }

            lblResumen.Text = $"Registros: {datosActuales.Filas.Count} | Periodo: {dtpDesde.Value:dd/MM/yyyy} - {dtpHasta.Value:dd/MM/yyyy}";
            CargarGrafico(datosActuales);
        }

        private void CargarCategorias(bool reiniciarCategoria, List<string> categorias)
        {
            actualizandoFiltros = true;
            string categoriaSeleccionada = reiniciarCategoria ? "Todos" : (cmbCategoria.SelectedItem?.ToString() ?? "Todos");
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Todos");
            foreach (var categoria in categorias)
            {
                cmbCategoria.Items.Add(categoria);
            }

            if (cmbCategoria.Items.Contains(categoriaSeleccionada))
            {
                cmbCategoria.SelectedItem = categoriaSeleccionada;
            }
            else
            {
                cmbCategoria.SelectedIndex = 0;
            }
            actualizandoFiltros = false;
        }

        private DatosReporte ConstruirDatosReporte()
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;
            if (desde > hasta)
            {
                (desde, hasta) = (hasta, desde);
            }

            string categoria = cmbCategoria.SelectedItem?.ToString() ?? "Todos";
            return reporteActual switch
            {
                TipoReporte.Ordenes => ConstruirReporteOrdenes(desde, hasta, categoria),
                TipoReporte.Produccion => ConstruirReporteProduccion(desde, hasta, categoria),
                TipoReporte.Distribucion => ConstruirReporteDistribucion(desde, hasta, categoria),
                _ => ConstruirReporteMovimientosInsumos(desde, hasta, categoria)
            };
        }

        private DatosReporte ConstruirReporteMovimientosInsumos(DateTime desde, DateTime hasta, string categoria)
        {
            var origen = GlobalData.MovimientosInsumos
                .Where(m => m.Fecha.Date >= desde && m.Fecha.Date <= hasta)
                .OrderByDescending(m => m.Fecha)
                .ToList();

            var categorias = origen.Select(m => m.Insumo).Distinct().OrderBy(x => x).ToList();
            if (categoria != "Todos")
            {
                origen = origen.Where(m => m.Insumo == categoria).ToList();
            }

            return new DatosReporte
            {
                Titulo = "Movimientos de insumos",
                Descripcion = "Consulta dinámica por fecha e insumo con gráfico de cantidades movilizadas.",
                EtiquetaCategoria = "Insumo",
                SerieNombre = "Cantidad movilizada",
                TipoGrafico = TipoGrafico.Barras,
                Categorias = categorias,
                Encabezados = new List<string> { "Documento", "Fecha", "Tipo", "Insumo", "Cantidad", "Referencia", "Detalle" },
                Filas = origen.Select(m => new[]
                {
                    m.Documento,
                    m.Fecha.ToString("dd/MM/yyyy"),
                    m.Tipo,
                    m.Insumo,
                    m.Cantidad.ToString("F2"),
                    m.Referencia,
                    m.Detalle
                }).ToList(),
                PuntosGrafico = origen
                    .GroupBy(m => m.Insumo)
                    .Select(g => (g.Key, g.Sum(x => Math.Abs(x.Cantidad))))
                    .OrderByDescending(x => x.Item2)
                    .ToList()
            };
        }

        private DatosReporte ConstruirReporteOrdenes(DateTime desde, DateTime hasta, string categoria)
        {
            var origen = GlobalData.OrdenesProduccion
                .Where(o => o.Fecha.Date >= desde && o.Fecha.Date <= hasta)
                .OrderByDescending(o => o.Fecha)
                .ToList();

            var categorias = origen.Select(o => o.Formula).Distinct().OrderBy(x => x).ToList();
            if (categoria != "Todos")
            {
                origen = origen.Where(o => o.Formula == categoria).ToList();
            }

            return new DatosReporte
            {
                Titulo = "Órdenes de producción",
                Descripcion = "Estado, avance y volumen programado por fórmula.",
                EtiquetaCategoria = "Fórmula",
                SerieNombre = "Objetivo",
                TipoGrafico = TipoGrafico.Lineas,
                Categorias = categorias,
                Encabezados = new List<string> { "Orden", "Fecha", "Fórmula", "Objetivo", "Producido", "Pendiente", "Estado" },
                Filas = origen.Select(o => new[]
                {
                    o.Numero,
                    o.Fecha.ToString("dd/MM/yyyy"),
                    o.Formula,
                    o.CantidadObjetivo.ToString("F2"),
                    o.CantidadProducida.ToString("F2"),
                    Math.Max(o.CantidadObjetivo - o.CantidadProducida, 0).ToString("F2"),
                    o.Estado
                }).ToList(),
                PuntosGrafico = origen
                    .GroupBy(o => o.Fecha.ToString("dd/MM"))
                    .Select(g => (g.Key, g.Sum(x => x.CantidadObjetivo)))
                    .OrderBy(x => x.Key)
                    .ToList()
            };
        }

        private DatosReporte ConstruirReporteProduccion(DateTime desde, DateTime hasta, string categoria)
        {
            var origen = GlobalData.ProduccionesAlimento
                .Where(p => p.Fecha.Date >= desde && p.Fecha.Date <= hasta)
                .OrderByDescending(p => p.Fecha)
                .ToList();

            var categorias = origen.Select(p => p.Formula).Distinct().OrderBy(x => x).ToList();
            if (categoria != "Todos")
            {
                origen = origen.Where(p => p.Formula == categoria).ToList();
            }

            return new DatosReporte
            {
                Titulo = "Producción de alimento balanceado",
                Descripcion = "Volumen producido por fórmula con referencia de salida e ingreso.",
                EtiquetaCategoria = "Fórmula",
                SerieNombre = "Producción",
                TipoGrafico = TipoGrafico.Torta,
                Categorias = categorias,
                Encabezados = new List<string> { "Documento", "Fecha", "Orden", "Fórmula", "Cantidad", "Salida", "Ingreso" },
                Filas = origen.Select(p => new[]
                {
                    p.Numero,
                    p.Fecha.ToString("dd/MM/yyyy"),
                    p.OrdenProduccionNumero,
                    p.Formula,
                    p.CantidadProducida.ToString("F2"),
                    p.OrdenSalidaInsumoNumero,
                    GlobalData.NotasIngresoAlimento.FirstOrDefault(n => n.ProduccionNumero == p.Numero)?.Numero ?? string.Empty
                }).ToList(),
                PuntosGrafico = origen
                    .GroupBy(p => p.Formula)
                    .Select(g => (g.Key, g.Sum(x => x.CantidadProducida)))
                    .OrderByDescending(x => x.Item2)
                    .ToList()
            };
        }

        private DatosReporte ConstruirReporteDistribucion(DateTime desde, DateTime hasta, string categoria)
        {
            var origen = GlobalData.OrdenesIngresoDistribucion
                .Where(d => d.Fecha.Date >= desde && d.Fecha.Date <= hasta)
                .OrderByDescending(d => d.Fecha)
                .ToList();

            var categorias = origen.Select(d => d.Galpon).Distinct().OrderBy(x => x).ToList();
            if (categoria != "Todos")
            {
                origen = origen.Where(d => d.Galpon == categoria).ToList();
            }

            return new DatosReporte
            {
                Titulo = "Distribución a galpones",
                Descripcion = "Despachos realizados por galpón y fórmula con filtro dinámico.",
                EtiquetaCategoria = "Galpón",
                SerieNombre = "Distribución",
                TipoGrafico = TipoGrafico.Dona,
                Categorias = categorias,
                Encabezados = new List<string> { "Documento", "Fecha", "Galpón", "Fórmula", "Cantidad", "Solicitud" },
                Filas = origen.Select(d => new[]
                {
                    d.Numero,
                    d.Fecha.ToString("dd/MM/yyyy"),
                    d.Galpon,
                    d.Formula,
                    d.Detalles.Sum(x => x.Cantidad).ToString("F2"),
                    d.SolicitudNumero
                }).ToList(),
                PuntosGrafico = origen
                    .GroupBy(d => d.Galpon)
                    .Select(g => (g.Key, g.Sum(x => x.Detalles.Sum(d => d.Cantidad))))
                    .OrderByDescending(x => x.Item2)
                    .ToList()
            };
        }

        private void CargarGrafico(DatosReporte datos)
        {
            picGrafico.Image?.Dispose();
            picGrafico.Image = CrearGrafico(datos, Math.Max(picGrafico.Width, 300), Math.Max(picGrafico.Height, 160));
        }

        private static Bitmap CrearGrafico(DatosReporte datos, int ancho, int alto)
        {
            Bitmap bmp = new(ancho, alto);
            using Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle area = new(10, 10, ancho - 20, alto - 20);
            using Font titulo = new("Segoe UI", 10, FontStyle.Bold);
            using Font texto = new("Segoe UI", 8);
            using Brush brushTexto = new SolidBrush(Color.FromArgb(44, 62, 80));
            using Pen penEjes = new(Color.FromArgb(210, 214, 220), 1);

            g.DrawString(datos.Titulo, titulo, brushTexto, area.Left, area.Top);
            Rectangle graficoArea = new(area.Left + 10, area.Top + 28, area.Width - 20, area.Height - 38);

            if (datos.PuntosGrafico.Count == 0)
            {
                g.DrawString("Sin datos para el período seleccionado.", texto, Brushes.Gray, graficoArea.Left, graficoArea.Top + 20);
                return bmp;
            }

            Color[] colores =
            {
                Color.FromArgb(0, 125, 62),
                Color.FromArgb(59, 130, 246),
                Color.FromArgb(249, 115, 22),
                Color.FromArgb(168, 85, 247),
                Color.FromArgb(236, 72, 153),
                Color.FromArgb(14, 165, 233),
                Color.FromArgb(245, 158, 11),
                Color.FromArgb(34, 197, 94)
            };

            switch (datos.TipoGrafico)
            {
                case TipoGrafico.Lineas:
                    DibujarLineas(g, graficoArea, datos.PuntosGrafico, colores, texto, penEjes, brushTexto);
                    break;
                case TipoGrafico.Torta:
                    DibujarCircular(g, graficoArea, datos.PuntosGrafico, colores, texto, brushTexto, false);
                    break;
                case TipoGrafico.Dona:
                    DibujarCircular(g, graficoArea, datos.PuntosGrafico, colores, texto, brushTexto, true);
                    break;
                default:
                    DibujarBarras(g, graficoArea, datos.PuntosGrafico, colores, texto, penEjes, brushTexto);
                    break;
            }

            return bmp;
        }

        private static void DibujarBarras(
            Graphics g,
            Rectangle area,
            List<(string Etiqueta, double Valor)> puntos,
            Color[] colores,
            Font texto,
            Pen penEjes,
            Brush brushTexto)
        {
            double max = puntos.Max(p => p.Valor);
            if (max <= 0) max = 1;

            int margenInferior = 40;
            int margenIzquierdo = 40;
            int anchoBarras = Math.Max((area.Width - margenIzquierdo - 10) / Math.Max(puntos.Count, 1), 24);
            int baseY = area.Bottom - margenInferior;
            int altoUtil = area.Height - margenInferior - 10;

            g.DrawLine(penEjes, area.Left + margenIzquierdo, baseY, area.Right - 10, baseY);
            g.DrawLine(penEjes, area.Left + margenIzquierdo, area.Top + 10, area.Left + margenIzquierdo, baseY);

            for (int i = 0; i < puntos.Count; i++)
            {
                var punto = puntos[i];
                int x = area.Left + margenIzquierdo + i * anchoBarras + 8;
                int barraAncho = Math.Max(anchoBarras - 16, 12);
                int barraAlto = (int)Math.Round((punto.Valor / max) * altoUtil);
                Rectangle rect = new(x, baseY - barraAlto, barraAncho, barraAlto);

                using Brush brush = new SolidBrush(colores[i % colores.Length]);
                g.FillRectangle(brush, rect);
                g.DrawRectangle(Pens.Transparent, rect);
                g.DrawString(punto.Valor.ToString("F2"), texto, brushTexto, x - 4, rect.Top - 18);

                string etiqueta = AcortarTexto(punto.Etiqueta, 12);
                g.DrawString(etiqueta, texto, brushTexto, x - 6, baseY + 4);
            }
        }

        private static void DibujarLineas(
            Graphics g,
            Rectangle area,
            List<(string Etiqueta, double Valor)> puntos,
            Color[] colores,
            Font texto,
            Pen penEjes,
            Brush brushTexto)
        {
            double max = puntos.Max(p => p.Valor);
            if (max <= 0) max = 1;

            int margenInferior = 35;
            int margenIzquierdo = 40;
            int baseY = area.Bottom - margenInferior;
            int altoUtil = area.Height - margenInferior - 10;
            int anchoUtil = area.Width - margenIzquierdo - 20;

            g.DrawLine(penEjes, area.Left + margenIzquierdo, baseY, area.Right - 10, baseY);
            g.DrawLine(penEjes, area.Left + margenIzquierdo, area.Top + 10, area.Left + margenIzquierdo, baseY);

            if (puntos.Count == 1)
            {
                puntos = new List<(string Etiqueta, double Valor)>
                {
                    puntos[0],
                    (puntos[0].Etiqueta, puntos[0].Valor)
                };
            }

            PointF[] coordenadas = new PointF[puntos.Count];
            for (int i = 0; i < puntos.Count; i++)
            {
                float x = area.Left + margenIzquierdo + (float)(i * anchoUtil / Math.Max(puntos.Count - 1, 1));
                float y = baseY - (float)((puntos[i].Valor / max) * altoUtil);
                coordenadas[i] = new PointF(x, y);
            }

            using Pen linea = new(colores[1], 3);
            g.DrawLines(linea, coordenadas);

            for (int i = 0; i < coordenadas.Length; i++)
            {
                using Brush puntoBrush = new SolidBrush(colores[i % colores.Length]);
                g.FillEllipse(puntoBrush, coordenadas[i].X - 4, coordenadas[i].Y - 4, 8, 8);
                g.DrawString(puntos[i].Valor.ToString("F2"), texto, brushTexto, coordenadas[i].X - 10, coordenadas[i].Y - 20);
                g.DrawString(AcortarTexto(puntos[i].Etiqueta, 10), texto, brushTexto, coordenadas[i].X - 12, baseY + 4);
            }
        }

        private static void DibujarCircular(
            Graphics g,
            Rectangle area,
            List<(string Etiqueta, double Valor)> puntos,
            Color[] colores,
            Font texto,
            Brush brushTexto,
            bool dona)
        {
            double total = puntos.Sum(p => p.Valor);
            if (total <= 0) total = 1;

            int diametro = Math.Min(area.Height - 10, area.Width / 2);
            Rectangle pie = new(area.Left + 10, area.Top + 5, diametro, diametro);
            Rectangle leyenda = new(area.Left + diametro + 30, area.Top + 8, area.Width - diametro - 40, area.Height - 16);
            float anguloInicial = -90f;

            for (int i = 0; i < puntos.Count; i++)
            {
                float barrido = (float)(puntos[i].Valor / total * 360d);
                using Brush brush = new SolidBrush(colores[i % colores.Length]);
                g.FillPie(brush, pie, anguloInicial, barrido);
                anguloInicial += barrido;
            }

            if (dona)
            {
                Rectangle centro = new(pie.X + pie.Width / 4, pie.Y + pie.Height / 4, pie.Width / 2, pie.Height / 2);
                g.FillEllipse(Brushes.White, centro);
                g.DrawString(total.ToString("F2"), new Font("Segoe UI", 9, FontStyle.Bold), brushTexto, centro.X + 10, centro.Y + centro.Height / 2 - 8);
            }

            for (int i = 0; i < puntos.Count; i++)
            {
                int y = leyenda.Top + i * 18;
                using Brush brush = new SolidBrush(colores[i % colores.Length]);
                g.FillRectangle(brush, leyenda.Left, y + 3, 10, 10);
                string textoLeyenda = $"{AcortarTexto(puntos[i].Etiqueta, 16)}: {puntos[i].Valor:F2}";
                g.DrawString(textoLeyenda, texto, brushTexto, leyenda.Left + 16, y);
            }
        }

        private static string AcortarTexto(string valor, int maximo)
        {
            return valor.Length <= maximo ? valor : $"{valor[..Math.Max(0, maximo - 3)]}...";
        }

        private void ExportarExcel()
        {
            if (datosActuales == null)
            {
                return;
            }

            using SaveFileDialog dialogo = new()
            {
                Filter = "Excel (*.xls)|*.xls",
                FileName = $"{datosActuales.Titulo.Replace(' ', '_')}.xls"
            };

            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            StringBuilder html = new();
            html.AppendLine("<html><head><meta charset=\"utf-8\"></head><body>");
            html.AppendLine($"<h2>{EscaparHtml(datosActuales.Titulo)}</h2>");
            html.AppendLine($"<p>{EscaparHtml(lblResumen.Text)}</p>");
            html.AppendLine("<table border='1' cellspacing='0' cellpadding='4'>");
            html.AppendLine("<tr>");
            foreach (var encabezado in datosActuales.Encabezados)
            {
                html.AppendLine($"<th>{EscaparHtml(encabezado)}</th>");
            }
            html.AppendLine("</tr>");
            foreach (var fila in datosActuales.Filas)
            {
                html.AppendLine("<tr>");
                foreach (var celda in fila)
                {
                    html.AppendLine($"<td>{EscaparHtml(celda)}</td>");
                }
                html.AppendLine("</tr>");
            }
            html.AppendLine("</table></body></html>");

            File.WriteAllText(dialogo.FileName, html.ToString(), Encoding.UTF8);
            MessageBox.Show("Reporte exportado a Excel.", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExportarPdf()
        {
            if (datosActuales == null)
            {
                return;
            }

            using SaveFileDialog dialogo = new()
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = $"{datosActuales.Titulo.Replace(' ', '_')}.pdf"
            };

            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            List<string> lineas = new()
            {
                datosActuales.Titulo,
                lblResumen.Text,
                string.Join(" | ", datosActuales.Encabezados)
            };
            lineas.AddRange(datosActuales.Filas.Select(f => string.Join(" | ", f)));
            GenerarPdfBasico(dialogo.FileName, lineas);
            MessageBox.Show("Reporte exportado a PDF.", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void GenerarPdfBasico(string ruta, List<string> lineas)
        {
            StringBuilder contenido = new();
            contenido.AppendLine("BT");
            contenido.AppendLine("/F1 11 Tf");
            contenido.AppendLine("40 790 Td");
            for (int i = 0; i < lineas.Count; i++)
            {
                string linea = EscapePdfText(Recortar(lineas[i], 110));
                if (i == 0)
                {
                    contenido.AppendLine($"({linea}) Tj");
                }
                else
                {
                    contenido.AppendLine("0 -16 Td");
                    contenido.AppendLine($"({linea}) Tj");
                }
            }
            contenido.AppendLine("ET");

            string stream = contenido.ToString();
            List<int> offsets = new();
            StringBuilder pdf = new();
            pdf.AppendLine("%PDF-1.4");

            void AppendObject(int numero, string cuerpo)
            {
                offsets.Add(pdf.Length);
                pdf.AppendLine($"{numero} 0 obj");
                pdf.Append(cuerpo);
                pdf.AppendLine("endobj");
            }

            AppendObject(1, "<< /Type /Catalog /Pages 2 0 R >>\n");
            AppendObject(2, "<< /Type /Pages /Kids [3 0 R] /Count 1 >>\n");
            AppendObject(3, "<< /Type /Page /Parent 2 0 R /MediaBox [0 0 595 842] /Contents 4 0 R /Resources << /Font << /F1 5 0 R >> >> >>\n");
            AppendObject(4, $"<< /Length {Encoding.ASCII.GetByteCount(stream)} >>\nstream\n{stream}endstream\n");
            AppendObject(5, "<< /Type /Font /Subtype /Type1 /BaseFont /Helvetica >>\n");

            int inicioXref = pdf.Length;
            pdf.AppendLine("xref");
            pdf.AppendLine($"0 {offsets.Count + 1}");
            pdf.AppendLine("0000000000 65535 f ");
            foreach (int offset in offsets)
            {
                pdf.AppendLine($"{offset:D10} 00000 n ");
            }
            pdf.AppendLine("trailer");
            pdf.AppendLine($"<< /Size {offsets.Count + 1} /Root 1 0 R >>");
            pdf.AppendLine("startxref");
            pdf.AppendLine(inicioXref.ToString());
            pdf.AppendLine("%%EOF");

            File.WriteAllText(ruta, pdf.ToString(), Encoding.ASCII);
        }

        private static string EscapePdfText(string valor)
        {
            return valor.Replace("\\", "\\\\").Replace("(", "\\(").Replace(")", "\\)");
        }

        private static string Recortar(string valor, int maximo)
        {
            return valor.Length <= maximo ? valor : valor[..maximo];
        }

        private static string EscaparHtml(string valor)
        {
            return valor
                .Replace("&", "&amp;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt;")
                .Replace("\"", "&quot;");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<Dashboard>(this);
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<Ordenes>(this);
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<Distribucion>(this);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<Administrador>(this);
        }

        private void btnAlimento_Click(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<AlmacenAB>(this);
        }

        private void btnMolino_Click(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<Molino>(this);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<Reportes>(this);
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<Insumos>(this);
        }
    }
}
