using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("Home/{id:int}")]
        public void GetOrderById(int id)
        {
            int[] a = new int[] { 9, 2, 7 };
            int[] b = new int[] { 4, 2, 3 };
            int[] c = (a.Union(b)).OrderBy(o => o).ToArray();
            //a = (a.Concat(b)).OrderBy(o => o).ToArray();
            #region IsAnagramme deux mots
            var an1 = "SAMAALI";
            var an2 = "AIASMAL";
            isAnagram(an1, an2);
            #endregion

            #region trouver Anagrammes dans une liste
            List<string> listWords = new List<string>() { "AZE", "ABCD", "MMS", "AA", "SMS", "BACD", "EZA" };
            FindAnagramsInList(listWords);
            #endregion

            Ok("ok");
        }

        private static void FindAnagramsInList(List<string> listWords)
        {
            List<anagram> listAnagrams = new List<anagram>();
            int countWords = listWords.Count;
            int indx = 0;
            foreach (string word in listWords)
            {
                //while (indx != countWords - 1)
                for (int i = indx+1; i < countWords; i++)
                {
                    if (isAnagram(listWords[indx], listWords[i])) 
                        listAnagrams.Add(new anagram() { mot1 = listWords[indx], mot2 = listWords[i] });
                }
                indx++;

            }
            foreach (anagram item in listAnagrams)
            {
                Console.WriteLine($"{item.mot1} : {item.mot2}");
            }
        }

        public static void PrintListOfAnagrams(List<string> words)
        {

            Dictionary<int, List<string>> map = new Dictionary<int, List<string>>();
            foreach (var word in words)
            {
                char[] letters = word.ToCharArray();
                Array.Sort(letters);
                String newWord = new String(letters);
                int hash = newWord.GetHashCode();

                //find the code in the dictionary
                if (map.ContainsKey(hash))
                {
                    List<string> listOfWords = map[hash];
                    listOfWords.Add(word);
                    map.Remove(hash);
                    map.Add(hash, listOfWords); //put back the new list into the dictionary
                }
                else
                {
                    List<string> listOfWords = new List<string>();
                    listOfWords.Add(word);
                    map.Add(hash, listOfWords);
                }
            }
            //print the anagram words from the dictionary with length >1
            foreach (var key in map.Keys)
            {
                List<string> anagramWords = map[key];
                if (anagramWords.Count > 1)
                {
                    string r = String.Join(" : ", anagramWords.ToArray());
                    foreach (var w in anagramWords)
                    {
                        Console.WriteLine(w);
                    }
                }
            }
        }

        private static bool isAnagram(string an1, string an2)
        {
            char[] ar1 = an1.ToLower().ToCharArray();
            char[] ar2 = an2.ToLower().ToCharArray();
            Array.Sort(ar1);
            Array.Sort(ar2);
            string res1 = new string(ar1);
            string res2 = new string(ar2);
            return res1 == res2;
        }

        public class anagram
        {
            public string mot1 { get; set; }
            public string mot2 { get; set; }
        }


    }
}
