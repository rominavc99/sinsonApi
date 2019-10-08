using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using api_simpsons.Modules;
using api_simpsons.Dependencies;
using Microsoft.AspNetCore.Cors;

namespace api_simpsons.Controllers
{
    [Route("simpsons/[controller]")]
    [ApiController] 
    [EnableCors("AllowOrigin")]

    public class CharacterController : ICharacter
    {
        List<Character> listofCharacters => new List<Character> 
        {
            new Character 
            {
                Name = "Homero",
                LastName = "Simposon",
                SecondName = "Jay",
                Description = "Esposo de Marge y padre de Bart, Lisa y Maggie Simpson.",
                Age = 24,
                Photo = "http://pluspng.com/img-png/marge-simpson-hd-png-marge-simpson-2-png-1220.png"
            },

            new Character{
                Name = "Margory Simpson", 
                Age = 36, 
                Description = "Esposa de Homero, Madre de la familia Simpson.",
                Photo = "http://pluspng.com/img-png/marge-simpson-hd-png-marge-simpson-2-png-1220.png"         
            },

            new Character{
                Name = "Bart",
                LastName = "Simposon",
                Age = 10,
                Description = "Hermano de Lisa y Maggie Simpson.",
                Photo = "https://upload.wikimedia.org/wikipedia/en/a/aa/Bart_Simpson_200px.png"        
            },

            new Character{
                Name = "Lisa", 
                LastName = "Simpson",
                Age = 9, 
                Description = "Hermana de Bart y Maggie Simpsons.",
                Photo = "https://upload.wikimedia.org/wikipedia/en/thumb/e/ec/Lisa_Simpson.png/220px-Lisa_Simpson.png"         
            },
            new Character{
                Name = "Maggie", 
                LastName = "Simpson",
                Age = 2, 
                Description = "Hermana de Bart y Lisa Simpson.",
                Photo = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9d/Maggie_Simpson.png/220px-Maggie_Simpson.png"         
            },


        };

        [HttpGet("{id}")]
        public Character GetCharacter(int id){
            return listofCharacters[id];
        }

        [HttpGet]
        public List<Character> GetCharacterList()
        {
            return listofCharacters; 
        }
    }
}