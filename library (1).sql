-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 10, 2023 at 03:50 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `library`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `add_books` (IN `book_name` VARCHAR(30), IN `autor_name` VARCHAR(30), IN `publication` VARCHAR(30), IN `purchase_date` VARCHAR(40), IN `book_price` VARCHAR(20), IN `Books_Available` VARCHAR(30))   BEGIN
  INSERT INTO booktable (
    book_name,
    autor_name,
    publication,
    purchase_date,
    book_price,
    Books_Available
  )
  VALUES (
    book_name,
    autor_name,
    publication,
    purchase_date,
    book_price,
    Books_Available
  );
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `add_student` (IN `p_student_name` VARCHAR(30), IN `p_enrollment` VARCHAR(30), IN `p_department` VARCHAR(30), IN `p_contact` VARCHAR(20), IN `p_email` VARCHAR(30), IN `p_semester` VARCHAR(30))   BEGIN
  INSERT INTO student (student_name, enrollment,department, contact, email, semester)
  VALUES (p_student_name, p_enrollment, p_department,p_contact, p_email, p_semester);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `books` ()   SELECT book_name FROM booktable$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `reports` (IN `report_br` VARCHAR(30))   BEGIN
    IF report_br = 'Issue' THEN
        SELECT * FROM issue_book WHERE return_date = '';
    ELSEIF report_br = 'Return' THEN
        SELECT * FROM issue_book WHERE return_date != '';
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_addissuebook` (IN `student_name_aib` VARCHAR(30), IN `enrollment_no_aib` VARCHAR(30), IN `department_aib` VARCHAR(30), IN `contact_aib` VARCHAR(30), IN `email_aib` VARCHAR(30), IN `book_name_aib` VARCHAR(30), IN `issue_date_aib` VARCHAR(50), IN `return_date_aib` VARCHAR(50))   INSERT INTO issue_book
( student_name, enrollment_number, department, contact, email, book_name, issue_date, return_date )
VALUES 
( student_name_aib, enrollment_no_aib, department_aib, contact_aib, email_aib, book_name_aib, issue_date_aib, return_date_aib)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_login` (IN `p_username` VARCHAR(20), IN `p_password` VARCHAR(20))   BEGIN
  SELECT * FROM Login WHERE username = p_username AND password = p_password;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `update_issueBook` (IN `id_uib` INT(30), IN `return_date_uib` DATETIME)   UPDATE issue_book SET return_date = return_date_uib 
WHERE issue_ID = id_uib$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `viewbooks` (IN `book_name_var` VARCHAR(30))   BEGIN
    IF (book_name_var = '')
    THEN 
        SELECT * FROM booktable;
    ELSE
        SELECT * FROM booktable WHERE book_name LIKE CONCAT('%', book_name_var, '%');
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `view_issue_book` (IN `enrollment_num_ib` VARCHAR(30))   BEGIN
    IF enrollment_num_ib IS NULL OR enrollment_num_ib = '' THEN
        SELECT * FROM issue_book;
    ELSE
        SELECT * FROM issue_book WHERE enrollment_number = enrollment_num_ib AND return_date = '';
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `view_student` (IN `student_name_var` VARCHAR(30))   BEGIN
    IF (student_name_var = '')
    THEN 
        SELECT * FROM student;
    ELSE
        SELECT * FROM student WHERE student_name LIKE CONCAT('%', student_name_var, '%');
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `view_student_issue_book` (IN `student_name_var_issue_book` VARCHAR(30))   BEGIN
    IF (student_name_var_issue_book <> '') THEN
        SELECT * FROM student WHERE student_name LIKE CONCAT('%', student_name_var_issue_book, '%');
    END IF;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `booktable`
--

CREATE TABLE `booktable` (
  `book_ID` int(20) NOT NULL,
  `book_name` varchar(30) NOT NULL,
  `autor_name` varchar(30) NOT NULL,
  `publication` varchar(30) NOT NULL,
  `purchase_date` varchar(40) NOT NULL,
  `book_price` varchar(20) NOT NULL,
  `Books_Available` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `booktable`
--

INSERT INTO `booktable` (`book_ID`, `book_name`, `autor_name`, `publication`, `purchase_date`, `book_price`, `Books_Available`) VALUES
(1, 'The Alchemist', 'Paulo Coelho', 'HarperCollins', '2022-03-10', '12.99', '10'),
(2, 'naruto', 'jellian', 'may q', '2023-03-10', '2000', '10'),
(3, 'UI Design', 'Rebadulla', 'jan 23', '2023-03-10', '2500', '10'),
(4, 'Ibong Adarna', 'Roseller Pelonia', 'March 11 2023', '2023-03-11', '900', '20'),
(5, 'Ang pagong at ang matsing', 'Russ', '2023-03-10', '01-03-023', '200', '4'),
(6, 'fsdfs', 'sfksajfsk', 'sfljaf', 'wfljsfdl', 'fsdlfkjl', 'sdfljdflk'),
(7, 'puno', 'russ', '2023-03-22', 'sk', '1000', '3'),
(8, 'jggj', 'ghgj', '2023-03-10', 'jhjh', 'fgfg', 'gghgh'),
(9, 'A Handbook of Agile Software C', ' Robert C. Martin', '2023-03-10', 'Prentice Hall', '1000', '100'),
(10, ' A Handbook of Agile Software ', ' Robert C. Martin', 'Prentice Hall', 'Prentice Hall', '1000', '100'),
(11, 'A Handbook of Agile Software C', 'Robert C. Martin', 'Prentice Hall', '2023-04-19', '1050', '150');

-- --------------------------------------------------------

--
-- Table structure for table `issue_book`
--

CREATE TABLE `issue_book` (
  `issue_ID` int(1) NOT NULL,
  `student_name` varchar(30) NOT NULL,
  `enrollment_number` varchar(30) NOT NULL,
  `department` varchar(30) NOT NULL,
  `contact` varchar(30) NOT NULL,
  `email` varchar(30) NOT NULL,
  `book_name` varchar(30) NOT NULL,
  `issue_date` varchar(20) NOT NULL,
  `return_date` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `issue_book`
--

INSERT INTO `issue_book` (`issue_ID`, `student_name`, `enrollment_number`, `department`, `contact`, `email`, `book_name`, `issue_date`, `return_date`) VALUES
(3, 'jellian', '23444', 'BSIT', '12345', 'jwela@gmai;.com', '', '2023-03-10', '2023-03-17 '),
(5, 'russ', '234232324', 'MIS', '09651623684', 'roseller.pelonia@gmail.com', '', '2023-03-10', '2023-03-17 '),
(7, 'jewwy', '345', 'BSIT', '09095500686', 'jewwy@gmail.com', 'The Alchemist', '2024-02-22', '2023-11-22'),
(8, 'Jellian', '123456', 'BSIT', '09095558697', 'jellian@gmail.com', 'Ang pagong at ang matsing', '2023-03-10', '2023-03-07 '),
(9, 'Jellian', '123456', 'BSIT', '09095558697', 'jellian@gmail.com', 'UI Design', '2023-03-09', '2023-03-17 00:00:00'),
(10, 'Jellian', '123456', 'BSIT', '09095558697', 'jellian@gmail.com', 'The Alchemist', '2023-03-10', ''),
(11, '', '', '', '', '', 'The Alchemist', '2023-03-10', ''),
(12, 'Jellian', '123456', 'BSIT', '09095558697', 'jellian@gmail.com', 'The Alchemist', '2023-03-10', ''),
(13, 'russ', '234232324', 'MIS', '09651623684', 'roseller.pelonia@gmail.com', 'A Handbook of Agile Software C', '2023-03-10', ''),
(14, 'russ', '234232324', 'MIS', '09651623684', 'roseller.pelonia@gmail.com', 'naruto', '2023-03-10', '2023-04-06 '),
(15, 'russ', '234232324', 'MIS', '09651623684', 'roseller.pelonia@gmail.com', 'Ang pagong at ang matsing', '2023-04-20', '2023-04-20');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `username` varchar(20) DEFAULT NULL,
  `password` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`username`, `password`) VALUES
('jellian', '22222');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `student_name` varchar(20) NOT NULL,
  `enrollment` varchar(30) NOT NULL,
  `department` varchar(30) NOT NULL,
  `contact` varchar(20) NOT NULL,
  `email` varchar(30) NOT NULL,
  `semester` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`student_name`, `enrollment`, `department`, `contact`, `email`, `semester`) VALUES
('fssdfj', 'sdlfkjkl', 'fsdkfjkld', 'fsdfksj', 'fs.djsd', 'lsdjflskf'),
('russ', '234232324', 'MIS', '09651623684', 'roseller.pelonia@gmail.com', '2nd sem'),
('Jellian', '123456', 'BSIT', '09095558697', 'jellian@gmail.com', '2nd Sem'),
('Mak', '12345', 'BSIT', '0909287547594', 'mak@gmaial.com', '2nd'),
('sada', 'kjkj', 'kjj', 'jkj', 'kjkkl', 'nmn');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `booktable`
--
ALTER TABLE `booktable`
  ADD PRIMARY KEY (`book_ID`);

--
-- Indexes for table `issue_book`
--
ALTER TABLE `issue_book`
  ADD PRIMARY KEY (`issue_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `booktable`
--
ALTER TABLE `booktable`
  MODIFY `book_ID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `issue_book`
--
ALTER TABLE `issue_book`
  MODIFY `issue_ID` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
