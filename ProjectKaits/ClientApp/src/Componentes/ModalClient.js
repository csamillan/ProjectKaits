import { Button, Table, Modal, ModalHeader, ModalBody, ModalFooter } from "reactstrap"

const ModalClient = ({ dataClient, mostrarModalClient, setMostrarModalClient }) => {

    return (
        <Modal isOpen={mostrarModalClient}>
            <ModalHeader>
                Lista de Clientes
            </ModalHeader>
            <ModalBody>
                <Table striped responsive>
                    <thead>
                        <tr>
                            <th> Id</th>
                            <th> Nombre de Cliente</th>
                            <th> DNI</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            (dataClient.length < 1) ? (
                                <tr>
                                    <td colSpan="4"> Sin Registros</td>
                                </tr>
                            ) : (
                                dataClient.map((item) => (
                                    <tr key={item.clientId}>
                                        <td>{item.clientId}</td>
                                        <td>{item.clientName}</td>
                                        <td>{item.dni}</td>
                                        <td>
                                            <Button color="primary" size="sm" className="me-2">Seleccionar</Button>
                                        </td>
                                    </tr>
                                ))
                            )
                        }
                    </tbody>
                </Table>
            </ModalBody>
            <ModalFooter>
                <Button color="danger" size="sm" onClick={() => setMostrarModalClient(!mostrarModalClient)}>Cerrar</Button>
            </ModalFooter>
        </Modal>
    )
}

export default ModalClient;