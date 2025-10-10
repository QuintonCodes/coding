import os
from dotenv import load_dotenv

load_dotenv()

API_KEY = os.getenv("FOOTBALL_API_KEY", "").strip()

BASE_URL = "https://api.football-data.org/v4"
HEADERS = {
    "X-Auth-Token": API_KEY,
    "Accept": "application/json"
}