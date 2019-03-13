using System.Collections.Generic;
using InfoSystem.Core.Entities.Basic;
using InfoSystem.Infrastructure.DataBase.Context;
using InfoSystem.Infrastructure.DataBase.Repos;
using InfoSystem.Infrastructure.DataBase.ReposInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace InfoSystem.Web.Controllers
{
	/// <inheritdoc />
	[Route("api/[controller]/[action]")]
	public class AttributeController : Controller
	{
		/// <inheritdoc />
		public AttributeController()
		{
			_repository = new AttributeRepository(new InfoSystemDbContext());
		}

		/// <summary>
		/// Adds a new Attribute to a entityType.
		/// </summary>
		/// <param name="attributeName">Name of a new attribute.</param>
		/// <param name="valueType">Type of data that would be stored.</param>
		/// <param name="typeName">Entity type name.</param>
		/// <returns>ActionResult, depending on operation result </returns>
		[HttpPost]
		public IActionResult Add(string typeName, string attributeName, string value, int typeId, int entityId)
		{
			var addedAttribute = _repository.Add(typeName, attributeName, value, typeId, entityId);
			if (!addedAttribute)
				return BadRequest();
			return Ok();
		}

		/// <summary>
		/// Gets all attributes that refers to type.
		/// </summary>
		/// <param name="typeId">Entity type id.</param>
		/// <returns>Attributes refering to type collection.</returns>
		[HttpGet]
		public IEnumerable<Attribute> GetAttributesByTypeId([FromQuery] int typeId) =>
			_repository.GetTypeAttributesById(typeId);

		[HttpGet]
		public IEnumerable<Attribute> GetByEntityId([FromQuery] int entityId, int typeId) =>
			_repository.GetByEntityId(entityId, typeId);

	    [HttpGet]
	    public IEnumerable<Attribute> GetByTypeName([FromQuery] int entityId, string typeName) =>
	        _repository.GetByTypeName(entityId, typeName);


        private readonly IAttributeRepository _repository;
	}
}