﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ListaPraticaGrafos.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ListaPraticaGrafos.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Formato do Arquivo de Entrada:
        ///
        ///Para a realização dos testes e avaliação do código desenvolvido, será fornecido um arquivo texto de
        ///entrada que apresentará, na primeira linha, o número de vertices do grafo. As linhas seguintes desse
        ///arquivo de entrada conterão, cada uma, informações sobre cada aresta do grafo, no seguinte
        ///formato: vértice v1; vértice v2; peso da aresta; direção da aresta. Apenas grafos dirigidos
        ///apresentarão esse último valor em cada linha do arquivo de entrada. Se o valor desse parâm [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Description {
            get {
                return ResourceManager.GetString("Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 3
        ///1; 2; 4; 1
        ///1; 2; 11; -1
        ///1; 3; 7; 1
        ///2; 3; 10; -1.
        /// </summary>
        internal static string GrafoDirigido {
            get {
                return ResourceManager.GetString("GrafoDirigido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 3
        ///1; 2; 4
        ///1; 3; 7
        ///2; 3; 10.
        /// </summary>
        internal static string GrafoNaoDirigido {
            get {
                return ResourceManager.GetString("GrafoNaoDirigido", resourceCulture);
            }
        }
    }
}