import metodos.RungeKutta.RungeKuttaMenu;
import metodos.bisection.BisectionCalculator;
import metodos.diferenciacionNumerica.NumericalDifferentiationMenu;
import metodos.gaussElimination.GaussEliminationCalculator;
import metodos.gaussGordan.GaussJordanCalculator;
import metodos.muller.MullerCalculator;
import metodos.newtonRaphson.NewtonRaphsonCalculator;
import metodos.other.MultiStepAdaptiveMenu;
import metodos.point.PointCalculator;
import metodos.secant.SecantCalculator;
import metodos.solucionNumericaEcuacionesDiferencialesOrdinarias.OrdinaryDifferentialEquationsMenu;

import javax.swing.*;
import java.awt.*;

public class main {
    public static void main(String[] args) {

        // Crear la ventana principal
        JFrame frame = new JFrame("Métodos Numéricos");
        frame.setSize(400, 450);
        frame.setLayout(new GridLayout(7, 1, 10, 10));
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        // Botón para abrir la calculadora de Bisección
        JButton bisectionButton = new JButton("Método de Bisección");
        configureButton(bisectionButton, e -> new BisectionCalculator(frame).setVisible(true));

        // Botón para abrir la calculadora de Punto Fijo (aún por implementar)
        JButton fixedPointButton = new JButton("Método de Punto Fijo");
        configureButton(fixedPointButton, e -> new PointCalculator(frame).setVisible(true));

        // Botón para abrir la calculadora de Newton-Raphson
        JButton newtonRaphsonButton = new JButton("Método de Newton-Raphson");
        configureButton(newtonRaphsonButton, e -> new NewtonRaphsonCalculator(frame).setVisible(true));

        // Botón para abrir la calculadora de la Secante
        JButton secantButton = new JButton("Método de la Secante");
        configureButton(secantButton, e -> new SecantCalculator(frame).setVisible(true));

        // Botón para abrir la calculadora de Müller
        JButton mullerButton = new JButton("Método de Müller");
        configureButton(mullerButton, e -> new MullerCalculator(frame).setVisible(true));

        // Botón para abrir la calculadora de Eliminación de Gauss
        JButton gaussButton = new JButton("Método de Eliminación de Gauss");
        configureButton(gaussButton, e -> new GaussEliminationCalculator(frame).setVisible(true));

        // Botón para abrir la calculadora de Gauss-Jordan
        JButton gaussJordanButton = new JButton("Método de Gauss-Jordan");
        configureButton(gaussJordanButton, e -> new GaussJordanCalculator(frame).setVisible(true));

        // Agregar botones al frame

        JButton derivationNumeric = new JButton(" Metodo de Direfenciacion Numerica");
        configureButton(derivationNumeric, e -> new NumericalDifferentiationMenu(frame).setVisible(true));

        // **Nuevo botón para abrir el menú de Solución Numérica de Ecuaciones Diferenciales**
        JButton odeButton = new JButton("Ecuaciones Diferenciales Ordinarias");
        configureButton(odeButton, e -> new OrdinaryDifferentialEquationsMenu(frame).setVisible(true));

// **Nuevo botón para abrir el menú de Solución Numérica de Ecuaciones Diferenciales**
        JButton RungeKutta = new JButton("Runge Kutta");
        configureButton(RungeKutta, e -> new RungeKuttaMenu(frame).setVisible(true));
// **Nuevo botón para abrir el menú de Solución Numérica de Ecuaciones Diferenciales**
        JButton mutlo = new JButton("Multiple Adaptative");
        configureButton(mutlo, e -> new MultiStepAdaptiveMenu(
                frame).setVisible(true));



        frame.add(bisectionButton);
        frame.add(fixedPointButton);
        frame.add(newtonRaphsonButton);
        frame.add(secantButton);
        frame.add(mullerButton);
        frame.add(gaussButton);
        frame.add(gaussJordanButton);
        frame.add(derivationNumeric);
        frame.add(odeButton);
        frame.add(RungeKutta);
        frame.add(mutlo);

        // Hacer visible la ventana principal
        frame.setLocationRelativeTo(null);
        frame.setVisible(true);
    }

    private static void configureButton(JButton button, java.awt.event.ActionListener action) {
        button.setFont(new Font("Arial", Font.BOLD, 14));
        button.setBackground(new Color(0, 153, 76));
        button.setForeground(Color.WHITE);
        button.setFocusPainted(false);
        button.addActionListener(action);
    }
}

