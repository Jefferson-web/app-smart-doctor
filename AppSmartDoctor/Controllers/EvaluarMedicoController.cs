﻿using AppSmartDoctor.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EvaluarMedicoController : ControllerBase
    {
        [HttpPost("CalificarMedico")]
        public dynamic CalificarMedico(Calificacion calificacion) {
            return CalificacionSOA.Calificar(calificacion);
        }

        [HttpGet("EditarComentario")]
        public Calificacion EditarComentario(int calificacionId, string comentario) {
            return CalificacionSOA.EditarComentario(calificacionId, comentario);
        }

        [HttpDelete("EliminarCalificacion/{calificacionId}")]
        public Calificacion EliminarCalificacion(int calificacionId) {
            return CalificacionSOA.EliminarCalificacion(calificacionId);
        }

        [HttpGet("VerCalificaciones/{medicoId}")]
        public IEnumerable<dynamic> VerCalificaciones(int medicoId) {
            return CalificacionSOA.VerCalificaciones(medicoId);
        }

        [HttpGet("VerPromedioCalificacion/{medicoId}")]
        public double VerPromedioCalificacion(int medicoId) {
            return CalificacionSOA.VerPromedioCalificacion(medicoId);
        }

        [HttpGet("VerCalificacion/{calificacionId}")]
        public Calificacion VerCalificacion(int calificacionId) {
            return CalificacionSOA.VerCalificacion(calificacionId);
        }

        [HttpGet("InfoMedico/{medicoId}")]
        public dynamic InfoMedico(int medicoId) {
            return CalificacionSOA.InfoMedico(medicoId);
        }

    }
}
