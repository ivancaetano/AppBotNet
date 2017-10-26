using HackIB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
namespace HackIB.Controllers
{
    public class SISGEDController : Controller
    {
        SISGED db = new SISGED();

        public ActionResult ListaDemandas(string coNIS)
        {
            List<gedtb001_demanda> lsDemandas = db.gedtb001_demanda
                .Include(f => f.gedtb002_historico_demanda)
                .Include(f => f.gedtb007_tipo_origem_demanda)
                .Include(f => f.gedtb004_servico)
                .Include(f => f.gedtb006_situacao)
                .Include(f => f.gedtb008_tipo_demanda)
                .Include(f => f.gedtb031_cidadao)
                .Where(d => d.gedtb031_cidadao.co_nis == coNIS)
                .OrderByDescending(d => d.co_demanda)
                .ToList()
                ;
            var retorno = Json(lsDemandas, JsonRequestBehavior.AllowGet);
            return retorno;
        }
	}
}