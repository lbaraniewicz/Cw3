using Cw3.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cw3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private static List<Student> _studenci = new List<Student>()
        {
        new Student()
        {
            Imie="Jan",
            Nazwisko="Nowak",
            Adres="Lazurowa 123",
            Email="koko@pp.pl",
            IdStudent=1,
            NrIndeksu=1234
        },
                new Student()
        {
            Imie="Milosz",
            Nazwisko="Muraw",
            Adres="Mickiewicz 123",
            Email="adad@pp.pl",
            IdStudent=2,
            NrIndeksu=1234
        }
        };


        // GET: api/<StudentsController>
        [HttpGet]
        public string Get()
        {
            return JsonConvert.SerializeObject(_studenci);
        }

        // POST api/<StudentsController>
        [HttpPost]
        public string Post([FromBody] Student value)
        {
            var student = JsonConvert.SerializeObject(value);
            _studenci.Add(value);
            return student;
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student value)
        {
            int index = _studenci.FindIndex(x => x.IdStudent == id);
            _studenci[index].Email = value.Email;
            _studenci[index].Adres = value.Adres;
            _studenci[index].NrIndeksu = value.NrIndeksu;
            _studenci[index].Imie = value.Imie;
            _studenci[index].Nazwisko = value.Nazwisko;
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            int index = _studenci.FindIndex(x => x.IdStudent == id);
            _studenci.RemoveAt(index);
        }
    }
}
