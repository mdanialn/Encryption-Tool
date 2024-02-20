using EncryptionTool.Helper;
using EncryptionTool.Models.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EncryptionTool.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        //// GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        [HttpPost]
        [Route("api/encrypt")]
        public string Encrypt([FromBody] DTOEncrypt dtoEncrypt)
        {
            var encryptedText = new Encryption().Encrypt(dtoEncrypt.PlainText, dtoEncrypt.Shift);
            return encryptedText;//Ok(encryptedText);
        }


        [Route("api/encryptfun")]
        public string Encryptfun([FromBody] DTOEncrypt dtoEncrypt)
        {
            var encryptedText = new Encryption().Encrypt(dtoEncrypt.PlainText, dtoEncrypt.Shift);
            return encryptedText;//Ok(encryptedText);
        }

        [HttpPost]
        [Route("api/decrypt")]
        public IHttpActionResult Decrypt([FromBody] DTODecrypt decrypt)
        {
            var decryptedText = new Encryption().Decrypt(decrypt.EncryptedText, decrypt.Shift);
            return Ok(decryptedText);
        }

        [HttpPost]
        [Route("api/decryptfun")]
        public IHttpActionResult Decryptfun([FromBody] DTODecrypt decrypt)
        {
            var decryptedText = new Encryption().Decrypt(decrypt.EncryptedText, decrypt.Shift);
            return Ok(decryptedText);
        }
        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
