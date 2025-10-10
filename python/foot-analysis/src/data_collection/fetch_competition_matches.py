import requests
import pandas as pd
from typing import Optional, Dict
from config.api_config import BASE_URL, HEADERS

def fetch_competition_matches(competition_id: str, params: Optional[Dict] = None) -> pd.DataFrame:
    """
    Fetch matches for a specific competition and season.

    Args:
      - competition_id: str, the competition code (e.g. "PL", "SA", "CL")
      - params: Optional dictionary of query parameters. Possible keys include:
        - dateFrom: str (YYYY-MM-DD)
        - dateTo: str (YYYY-MM-DD)
        - stage: str (e.g. "GROUP_STAGE", "KNOCKOUT_STAGE")
        - status: str (SCHEDULED, LIVE, FINISHED, etc.)
        - matchday: int (matchday number)
        - group: str (group name, e.g. "A", "B")
        - season: int (year of the season, e.g. 2023)
    """
    url = f"{BASE_URL}/competitions/{competition_id}/matches"

    response = requests.get(url, headers=HEADERS, params=params)
    if response.status_code != 200:
        print(f"Error {response.status_code}: {response.text}")
        return pd.DataFrame()

    data = response.json()
    matches = data.get("matches", [])
    df = pd.json_normalize(matches)
    print(f"Fetched {len(df)} matches for competition={competition_id}, params={params}")
    return df