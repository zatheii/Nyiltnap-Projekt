-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2025. Nov 05. 07:53
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `appappdb`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `doktor`
--

CREATE TABLE `doktor` (
  `id` int(11) NOT NULL,
  `nev` varchar(100) NOT NULL,
  `szakterulet` varchar(110) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `doktor`
--

INSERT INTO `doktor` (`id`, `nev`, `szakterulet`) VALUES
(1, 'Dr. Kovács Regina', 'belgyógyász'),
(2, 'Dr. Szabó Gábor', 'sebész'),
(3, 'Dr. Tóth Júlia', 'gyermekorvos'),
(4, 'Dr. Fekete László', 'bőrgyógyász'),
(5, 'Dr. Kiss Eszter', 'pszichiáter');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `felhasznalo`
--

CREATE TABLE `felhasznalo` (
  `taj` int(110) NOT NULL,
  `nev` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `felhasznalo`
--

INSERT INTO `felhasznalo` (`taj`, `nev`) VALUES
(123456789, 'Kovács Anna'),
(321654987, 'Nagy László'),
(456789123, 'Tóth Eszter'),
(654987321, 'Kiss Dóra'),
(987654321, 'Szabó Péter');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `foglalas`
--

CREATE TABLE `foglalas` (
  `id` int(11) NOT NULL,
  `felh_taj_fk` int(110) NOT NULL,
  `doktor_id_fk` int(11) NOT NULL,
  `idopont` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `foglalas`
--

INSERT INTO `foglalas` (`id`, `felh_taj_fk`, `doktor_id_fk`, `idopont`) VALUES
(8, 123456789, 1, '2025-11-10 09:00:00'),
(9, 987654321, 2, '2025-11-11 10:30:00'),
(10, 456789123, 3, '2025-11-12 13:15:00'),
(11, 321654987, 4, '2025-11-13 08:45:00'),
(12, 654987321, 5, '2025-11-14 15:00:00');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `doktor`
--
ALTER TABLE `doktor`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `felhasznalo`
--
ALTER TABLE `felhasznalo`
  ADD PRIMARY KEY (`taj`);

--
-- A tábla indexei `foglalas`
--
ALTER TABLE `foglalas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `pk_felh_taj` (`felh_taj_fk`),
  ADD KEY `fk_doktor_id` (`doktor_id_fk`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `doktor`
--
ALTER TABLE `doktor`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT a táblához `foglalas`
--
ALTER TABLE `foglalas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `foglalas`
--
ALTER TABLE `foglalas`
  ADD CONSTRAINT `fk_doktor_id` FOREIGN KEY (`doktor_id_fk`) REFERENCES `doktor` (`id`),
  ADD CONSTRAINT `pk_felh_taj` FOREIGN KEY (`felh_taj_fk`) REFERENCES `felhasznalo` (`taj`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
