using Microsoft.AspNetCore.Mvc;

namespace ConvTemp.Controllers
{
    public class TemperaturaController : Controller
    {
        [HttpGet]
        public IActionResult CelsiusFahrenheit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CelsiusFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;

            ViewBag.Resultado = fahrenheit;

            return View();
        }

        [HttpGet]
        public IActionResult CelsiusKelvin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CelsiusKelvin(double celsius)
        {
            double kelvin = celsius + 273.15;

            ViewBag.Resultado = kelvin;

            return View();
        }
        public IActionResult FahrenheitCelsius()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FahrenheitCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;

            ViewBag.Resultado = celsius;

            return View();
        }
        [HttpGet]
        public IActionResult FahrenheitKelvin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FahrenheitKelvin(double fahrenheit)
        {
            double kelvin = (fahrenheit - 32) * 5 / 9 + 273.15;

            ViewBag.Resultado = kelvin;

            return View();
        }
        [HttpGet]
        public IActionResult KelvinCelsius()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KelvinCelsius(double kelvin)
        {
            double celsius = kelvin - 273.15;

            ViewBag.Resultado = celsius;

            return View();
        }

        [HttpGet]
        public IActionResult KelvinFahrenheit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KelvinFahrenheit(double kelvin)
        {
            double fahrenheit = (kelvin - 273.15) * 9 / 5 + 32;

            ViewBag.Resultado = fahrenheit;

            return View();
        }
    }
}