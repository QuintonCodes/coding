import requests
import pandas as pd
from typing import Optional, Dict
from datetime import datetime, timedelta
from config.api_config import BASE_URL, HEADERS

def fetch_matches(params: Optional[Dict] = None) -> pd.DataFrame:
  """
  Fetch upcoming matches from the football API.

  Args:
    - params: Optional dictionary of query parameters. Possible keys include:
      - competitions: str (comma-separated competition codes, e.g. "PL,SA,CL")
      - ids: str (comma-separated match IDs)
      - dateFrom: str (YYYY-MM-DD)
      - dateTo: str (YYYY-MM-DD)
      - status: str (SCHEDULED, LIVE, FINISHED, etc.)
  """
  url = f"{BASE_URL}/matches"

  if params is None:
    params = {}
  if "dateFrom" not in params:
    params["dateFrom"] = datetime.today().strftime("%Y-%m-%d")
  if "dateTo" not in params:
    params["dateTo"] = (datetime.today() + timedelta(days=10)).strftime("%Y-%m-%d")

  response = requests.get(url, headers=HEADERS, params=params)

  if response.status_code != 200:
    print(f"Error {response.status_code}: {response.text}")
    return pd.DataFrame()

  data = response.json()
  matches = data.get("matches", [])
  df = pd.json_normalize(matches)
  print(f"Fetched {len(df)} matches.")
  return df