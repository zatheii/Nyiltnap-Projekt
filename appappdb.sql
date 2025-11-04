-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 04, 2025 at 08:16 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `appappdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `doktor`
--

CREATE TABLE `doktor` (
  `id` int(11) NOT NULL,
  `nev` varchar(100) NOT NULL,
  `szakterulet` varchar(110) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- Dumping data for table `doktor`
--

INSERT INTO `doktor` (`id`, `nev`, `szakterulet`) VALUES
(1, 'Dr. Kovács Regina', 'belgyógyász'),
(2, 'Dr. Szabó Gábor', 'sebész'),
(3, 'Dr. Tóth Júlia', 'gyermekorvos'),
(4, 'Dr. Fekete László', 'bőrgyógyász'),
(5, 'Dr. Kiss Eszter', 'pszichiáter');

-- --------------------------------------------------------

--
-- Table structure for table `felhasznalo`
--

CREATE TABLE `felhasznalo` (
  `taj` int(110) NOT NULL,
  `nev` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- Dumping data for table `felhasznalo`
--

INSERT INTO `felhasznalo` (`taj`, `nev`) VALUES
(123456789, 'Kovács Regina'),
(147258369, 'Szaki Fckboya'),
(185894983, 'Goyo'),
(943265439, 'Riki Musa'),
(987654321, 'P. Diddy'),
(999999999, 'nemtudom');

-- --------------------------------------------------------

--
-- Table structure for table `foglalas`
--

CREATE TABLE `foglalas` (
  `id` int(11) NOT NULL,
  `felh_taj_fk` int(110) NOT NULL,
  `doktor_id_fk` int(11) NOT NULL,
  `idopont` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- Dumping data for table `foglalas`
--

INSERT INTO `foglalas` (`id`, `felh_taj_fk`, `doktor_id_fk`, `idopont`) VALUES
(3, 123456789, 5, '2025-12-07 14:30:00'),
(4, 987654321, 3, '2025-11-28 11:45:00'),
(5, 147258369, 1, '2025-12-07 18:15:00'),
(6, 185894983, 4, '2025-12-24 08:30:00'),
(7, 943265439, 2, '2025-12-31 23:59:59');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `doktor`
--
ALTER TABLE `doktor`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `felhasznalo`
--
ALTER TABLE `felhasznalo`
  ADD PRIMARY KEY (`taj`);

--
-- Indexes for table `foglalas`
--
ALTER TABLE `foglalas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `pk_felh_taj` (`felh_taj_fk`),
  ADD KEY `fk_doktor_id` (`doktor_id_fk`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `doktor`
--
ALTER TABLE `doktor`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `foglalas`
--
ALTER TABLE `foglalas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `foglalas`
--
ALTER TABLE `foglalas`
  ADD CONSTRAINT `fk_doktor_id` FOREIGN KEY (`doktor_id_fk`) REFERENCES `doktor` (`id`),
  ADD CONSTRAINT `pk_felh_taj` FOREIGN KEY (`felh_taj_fk`) REFERENCES `felhasznalo` (`taj`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
