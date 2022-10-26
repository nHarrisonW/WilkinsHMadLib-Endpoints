//N. Harrison Wilkins
//10-26-2022
//MAD LIB - ENDPOINTS
//THIS PROJECT ALLOWS THE USER TO INPUT MAD LIB ANSWER VIA THE URL. THEN OUTPUT A SENTENCE ACCORDING TO THE USERS'S ANSWERS
/*
Peer review by Carlos Felipe - This code worked after HttpHead was changed to HttpGet after that it worked flawlessly. 
*/
using Microsoft.AspNetCore.Mvc;

namespace WilkinsHMadLib_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
    [HttpGet]
    [Route ("game/{word1}/{word2}/{word3}/{word4}/{word5}/{word6}/{word7}/{word8}/{word9}/{word10}")]
    public string MadLibGame(string word1, string word2, string word3, string word4, string word5, string word6, string word7, string word8, string word9, string word10)
    {
    return $"The {word1} made a {word2} with a {word3} on a {word4} with {word5}. Then the {word6} went {word7} with their{word8} {word9}. They lived happily ever after in there{word10}";
    }
}
