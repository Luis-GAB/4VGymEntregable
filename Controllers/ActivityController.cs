using _4VGymEntregable.Models;
using _4VGymEntregable.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _4VGymEntregable.Controllers {

    [ApiController]
    [Route("activities")]
    public class ActivityController : ControllerBase {

        private readonly InMemoryActivityRepository _repository;

        // Inyectamos la clase concreta del repositorio
        public ActivityController(InMemoryActivityRepository repository) {
            _repository = repository;
        }

        /// <summary>
        /// POST /activities
        /// Añade una nueva actividad en 4VGym.
        /// </summary>
        /// <param name="activity">ObjetoActivity enviado en el cuerpo de la petición (JSON).</param>
        [HttpPost]
        [ProducesResponseType(typeof(Activity), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        public ActionResult<Activity> CreateActivity([FromBody] Activity activity) {
            try {
                List<ErrorResponse> errors = new List<ErrorResponse>();
                Activity? activityCreated = _repository.Add(activity, out errors);
                if (activityCreated == null)
                {
                    return BadRequest(errors);
                }

                return StatusCode(StatusCodes.Status201Created, activity);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  new ErrorResponse(1, "An internal server error occurred"));

            }
        }

    }
}
