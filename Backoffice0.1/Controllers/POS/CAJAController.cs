﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Backoffice0._1.Models;
using Backoffice0._1.Helper;

namespace Backoffice0._1.Controllers
{
    public class CAJAController : Controller
    {
        private DB_CORPORATIVA_DEVEntities db = new DB_CORPORATIVA_DEVEntities();
        // GET: CAJA
        public ActionResult Index()
        {
          
            return View();
        }

        class SumaTotal
        {
            public decimal total { get; set; }
            public string nombreTipoPago { get; set; }
        }

        [HttpPost]
        public ActionResult cajaMovimientos(FormCollection form)
        {           
            C_pos_caja_movs obj = new C_pos_caja_movs();
            obj.usuario = form["usuario"];
            obj.terminal = form["caja"];
            obj.monto = form["monto"];
            obj.observacion = form["observaciones"];
            obj.fecha = DateTime.Now.ToShortDateString();
            obj.hora = DateTime.Now.ToShortTimeString();
            obj.tipo = "Venta";
          
            db.C_pos_caja_movs.Add(obj);
            db.SaveChanges();
            ViewData["userFlag"] = true; 
            ViewBag.Usuarios = db.CS_usuarios.ToList();
            Session["EstadoCaja"] = "Caja abierta";
            cambioDeTurno();
            return View("/Views/POS/Ventas/Index.cshtml");
            //return Json("Caja Abierta!", JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult validarCambio()

        { 
            if (ViewBag.granTotal != null)
            {
                
            }
            return View();
        }
        public void cambioDeTurno()
        {
            string fecha = DateTime.Now.ToShortDateString();
            List<Backoffice0._1.Models.SumaTotal> objVentas = new List<Backoffice0._1.Models.SumaTotal>();
           
            var idTipoProducto = db.C_ventas_pagos.SqlQuery("SELECT * FROM C_VENTAS_PAGOS WHERE FECHA between '2018-06-07 00:00:00' and '2018-06-07 23:59:59'");
            int i = 0;
            int? id = 0;
            foreach (var n in idTipoProducto)
            {
                if (n.id_pago_tipo != id)
                {
                    //to do: mejorar la consulta con un join y añadir un solo objeto a la lista
                    var ventas = db.Database.SqlQuery<Backoffice0._1.Models.SumaTotal>("SELECT SUM(total) as total FROM C_VENTAS_PAGOS WHERE FECHA between '2018-06-07 00:00:00' and '2018-06-07 23:59:59' and id_pago_tipo='"+n.id_pago_tipo+"'");
                    objVentas.Add(ventas.FirstOrDefault());
                    var nombreTipoPago = db.Database.SqlQuery<Backoffice0._1.Models.SumaTotal>("SELECT nombre_pago_tipo as nombreTipoPago FROM C_PAGO_TIPO WHERE id_pago_tipo =" + n.id_pago_tipo + "");
                    objVentas.Add(nombreTipoPago.FirstOrDefault());
                    id = n.id_pago_tipo;
                }
            }
          ViewBag.Ventas =objVentas.ToList();
          
        }
        public bool MovimientoCaja(decimal monto_apertura, int id_tipo_movimiento)
        {
            var codigo_sucursal = (string)Session["codigo_sucursal"];
            C_cajas_movimientos c_cajas_movimientos = new C_cajas_movimientos();
            c_cajas_movimientos.id_caja = 1;//(int)Session["LoggedIdCaja"];
            c_cajas_movimientos.id_cajas_tipo_mov = id_tipo_movimiento;
            c_cajas_movimientos.id_usuario = (int)Session["LoggedId"];
            c_cajas_movimientos.entrada_salida = true;
            c_cajas_movimientos.fecha_mov = DateTime.Now;
            c_cajas_movimientos.monto = monto_apertura;
            c_cajas_movimientos.status = true;
            c_cajas_movimientos.codigo_sucursal = codigo_sucursal;

            db.C_cajas_movimientos.Add(c_cajas_movimientos);
            db.SaveChanges();
            return true;
        }

        public bool ValidaAperturaCaja()
        {
            var fecha = DateTime.Today;
            var codigo_sucursal = (string)Session["codigo_sucursal"];
            var apertura_caja = db.C_cajas_movimientos.Where(x=>x.id_cajas_tipo_mov==1 && x.codigo_sucursal == codigo_sucursal && x.fecha_mov>fecha);
            if (apertura_caja.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}