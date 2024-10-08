from selenium import webdriver
from selenium.webdriver.chrome.service import Service
from selenium.webdriver.chrome.options import Options

# Especifica la ruta de Brave
brave_path = "/ruta/a/brave-browser"  # Cambia a la ruta donde Brave está instalado

# Especifica la ruta al ChromeDriver que descargaste
chromedriver_path = "/ruta/a/chromedriver"  # Cambia a la ruta donde está chromedriver

# Configura las opciones de Chrome para Brave
options = Options()
options.binary_location = brave_path

# Inicializa el servicio de ChromeDriver
service = Service(chromedriver_path)

# Inicia el navegador Brave con las opciones y servicio definidos
driver = webdriver.Chrome(service=service, options=options)

# Navega a una página de prueba
driver.get("https://www.google.com")

# Realiza cualquier otra acción que necesites
# ...

# Cierra el navegador
driver.quit()
