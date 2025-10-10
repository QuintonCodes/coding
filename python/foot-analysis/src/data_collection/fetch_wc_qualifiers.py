import requests
import pandas as pd

BASE_URL = "https://site.web.api.espn.com/apis/site/v2/sports/soccer/fifa.worldq.uefa/scoreboard"

def fetch_wc_qualifiers_json() -> pd.DataFrame:
    resp = requests.get(BASE_URL, timeout=10)
    data = resp.json()

    matches = []
    events = data.get("events", [])
    if not events:
        print("No events found in API response.")
        return pd.DataFrame()

    for event in events:
        competitions = event.get("competitions", [])
        if not competitions:
          continue

        competition = competitions[0]
        competitors = competition.get("competitors", [])

        home = next((c for c in competitors if c.get("homeAway") == "home"), None)
        away = next((c for c in competitors if c.get("homeAway") == "away"), None)

        matches.append({
            "home_team": home["team"]["displayName"] if home else None,
            "away_team": away["team"]["displayName"] if away else None,
            "home_score": home["score"] if home else None,
            "away_score": away["score"] if away else None,
            "status": competition.get("status", {}).get("type", {}).get("description"),
            "date": event.get("date"),
        })

    df = pd.DataFrame(matches)
    print(f"Fetched {len(df)} WC Qualifier matches.")
    return df

if __name__ == "__main__":
    df = fetch_wc_qualifiers_json()
    print(df)
