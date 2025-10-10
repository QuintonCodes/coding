from data_collection.fetch_competition_matches import fetch_competition_matches
from data_collection.io_utils import save_raw
from data_processing.preprocess import clean_matches
from data_processing.io_utils import save_processed

if __name__ == "__main__":
    # Example: Serie A 2023 season
    matches = fetch_competition_matches("SA", {"season": 2023})
    save_raw(matches, "serie_a_2023_raw")

    cleaned_matches = clean_matches(matches)
    save_processed(cleaned_matches, "serie_a_2023_cleaned")