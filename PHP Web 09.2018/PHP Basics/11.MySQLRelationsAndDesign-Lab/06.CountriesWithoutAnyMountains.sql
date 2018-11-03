SELECT COUNT(*) AS country_count
FROM COUNTRIES c
LEFT JOIN mountains_countries m ON c.country_code = m.country_code
WHERE m.mountain_id IS NULL